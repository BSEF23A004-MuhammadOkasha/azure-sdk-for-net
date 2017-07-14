::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
setlocal

if not "%1" == "" (set specsRepoUser="%1")
if not "%2" == "" (set specsRepoBranch="%2")
if "%specsRepoUser%" == ""   (set specsRepoUser="Azure")
if "%specsRepoBranch%" == "" (set specsRepoBranch="current")
set specFile="https://github.com/%specsRepoUser%/azure-rest-api-specs/blob/%specsRepoBranch%/specification/operationalinsights/resource-manager/readme.md"


set sdksRoot=%~dp0..\..

if "%3" == "" (call npm i -g autorest)
rd /S /Q %~dp0Generated

@echo on
call autorest %specFile% --csharp --csharp-sdks-folder=%sdksRoot% --latest

endlocal
