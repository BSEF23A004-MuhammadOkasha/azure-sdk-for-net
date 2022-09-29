# Take the input of the project list file. Read all files out and split them into groups, and return the group array. 
# Give the option of whether exclude the target service project files or not.

function Split-Project-File-To-Groups($ProjectFile, $NumberOfTestsPerJob, $ExcludeService, $ServiceDirToExclude) {
    $projects = Get-Content $ProjectFile
    if ($ExcludeService) {
      $projects = $projects.Where({ $_ -notmatch "sdk[\\/]+${ServiceDirToExclude}[\\/]+" })
    }
    if (!$projects) {
      throw "The project file is empty. Please check the input file: $ProjectFile"
    }
    $numOfGroups = [Math]::Ceiling([decimal]($projects.Count / $NumberOfTestsPerJob ))
    $projGroup = [System.Object[]]::New($numOfGroups)
    $i = 0
    while ($i -lt $projects.Count) {
      $groupNum = [Math]::Floor([decimal]($i / $NumberOfTestsPerJob ))
      if(!$projGroup[$groupNum]) {
        $projGroup[$groupNum] = [System.Collections.ArrayList]::new()
      }
      $serviceDir = $projects[$i] -replace '^.*(sdk[/|\\].*Azure.ResourceManager[^/|\\]+)[/|\\].*$', '$1'
      $projectInfo = New-Object -Typename PSCustomObject -Property @{
        PkgPath = $projects[$i]
        ServiceDirectory = $serviceDir
      }
      $projGroup[$groupNum].Add($projectInfo) > $null
      $i += 1
    }
    return ,$projGroup
}


# Take the group contains the project list. Write each group into a project file which can be used by dotnet test command.
# Return the array of project files
# We need to add prefix for each of the Prop files generated by the scripts in order to run two or more different tasks in the same pipeline. 
function Write-Test-Dependency-Group-To-Files($ProjectFileConfigName, $ProjectGroups, $MatrixOutputFolder) {
  if (!$ProjectGroups -or !$ProjectGroups[0]) {
    Throw "There should be some project files in the group. Please check the given project list."
  }
  $null = New-Item -Path $MatrixOutputFolder -ItemType "directory" -Force 
  $numOfGroups = $ProjectGroups.Count
  $projectListInfoArray = @()
  for ($i = 0; $i -lt $numOfGroups; $i++) {
    $projectFilePath = "${ProjectFileConfigName}_Project_$i.props"
    $null = New-Item -Path "$MatrixOutputFolder/$projectFilePath" -ItemType "file" -Force
    # Retain the structure without ProjectReference.
    $templateXml=[xml]'<Project></Project>'  
    $projectNode = $templateXml.SelectNodes("/Project")
    $itemGroupNode=$templateXml.CreateNode("element", "ItemGroup", "")
    $projectNode.AppendChild($itemGroupNode) > $null
    $ServiceDirectories = @()
    foreach($pkg in $ProjectGroups[$i]) {
      $newElem = $templateXml.CreateNode("element", "ProjectReference", "")
      $newElemAttr = $templateXml.CreateAttribute("Include")
      $newElemAttr.InnerText = $pkg.PkgPath
      $newElem.Attributes.Append($newElemAttr) > $null
      $itemGroupNode.AppendChild($newElem) > $null
      $ServiceDirectories += $($pkg.ServiceDirectory)
    }
    $ServiceDirectoriesJson = ConvertTo-Json @($ServiceDirectories | Get-Unique) -Compress
    $null = $templateXml.Save("$MatrixOutputFolder/$projectFilePath")
    $Service
    $projectListInfo = New-Object -Typename PSCustomObject -Property @{
      ProjectListFile = "$MatrixOutputFolder/$projectFilePath"
      ServiceDirectories = $ServiceDirectoriesJson
    }
    $projectListInfoArray += $projectListInfo
  }
  return $projectListInfoArray
}

# Add new property in the platform-matrix json and assign the values of the project file paths.
function Write-Project-Files-To-Matrix($ProjListInfos, $MatrixJsonPath, $MatrixOutputFolder, $ProjectFileConfigName, $ServiceDirectories) {
  if (!(Test-Path $MatrixOutputFolder)) {
    New-Item -Path $MatrixOutputFolder -ItemType "directory" -Force > $null
  }
  $platformJson = Get-Content $MatrixJsonPath | ConvertFrom-Json
  $overrideFiles = New-Object PSObject
  foreach ($projectListInfo in $ProjListInfos) {
    $n = $projectListInfo.ProjectListFile -replace ".*$([regex]::escape($ProjectFileConfigName))_Project_(\d+).props", '$1'
    # Write $ServiceDirectories into the job matrix
    $PropertyOverride = New-Object -Typename PSCustomObject -Property @{
      $($ProjectFileConfigName) = $projectListInfo.ProjectListFile
      ServiceDirectories = $projectListInfo.ServiceDirectories
    }
    $overrideFiles | Add-Member -Name "DependencyGroup$n" -value $PropertyOverride -MemberType NoteProperty
  }
  # Add one project files into the "include" session for short-term solution. Check whether "include" property exists.
  if ("include" -in $platformJson.PSobject.Properties.Name) {
    foreach ($include in $platformJson.include) {
      if (!$overrideFiles) {
        Throw "Need at least one project file for include property. Please adjust the NumberOfTestsPerJob for better split."
      }
      $lastElem = $overrideFiles.PSObject.Properties | Select-Object -Last 1
      $overrideFiles.PSObject.properties.remove($lastElem.Name)
      
      $dependencyGroup = [PSCustomObject]@{
        "DependencyGroup$n" = $lastElem.Value
      }
      $include | Add-Member -Name "OverrideFiles" -value $dependencyGroup -MemberType NoteProperty
    }
  }
  if (!$($overrideFiles.PSObject.properties)) {
    Throw "Need at least one project file for test matrix. Please adjust the NumberOfTestsPerJob for better split."
  }
  $platformJson.matrix | Add-Member -Name "OverrideFiles" -value $overrideFiles -MemberType NoteProperty
  $platformJson | ConvertTo-Json -Depth 100 | Out-File $MatrixJsonPath 
  Copy-Item $MatrixJsonPath -Destination $MatrixOutputFolder
}