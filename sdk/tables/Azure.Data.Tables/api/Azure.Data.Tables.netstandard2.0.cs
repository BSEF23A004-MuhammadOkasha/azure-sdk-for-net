namespace Azure.Data.Tables
{
    public partial class TableClient
    {
        protected TableClient() { }
        public virtual Azure.Data.Tables.Models.TableResponse Create(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Data.Tables.Models.TableResponse> CreateAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Delete(string partitionKey, string rowKey, string eTag = "*", System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteAsync(string partitionKey, string rowKey, string eTag = "*", System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyDictionary<string, object>> Insert(System.Collections.Generic.IDictionary<string, object> entity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyDictionary<string, object>>> InsertAsync(System.Collections.Generic.IDictionary<string, object> entity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Merge(System.Collections.Generic.IDictionary<string, object> entity, string eTag = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> MergeAsync(System.Collections.Generic.IDictionary<string, object> entity, string eTag = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<System.Collections.Generic.IDictionary<string, object>> Query(string select = null, string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<System.Collections.Generic.IDictionary<string, object>> QueryAsync(string select = null, string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Update(System.Collections.Generic.IDictionary<string, object> entity, string eTag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAsync(System.Collections.Generic.IDictionary<string, object> entity, string eTag, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Upsert(System.Collections.Generic.IDictionary<string, object> entity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpsertAsync(System.Collections.Generic.IDictionary<string, object> entity, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TableClientOptions : Azure.Core.ClientOptions
    {
        public TableClientOptions(Azure.Data.Tables.TableClientOptions.ServiceVersion serviceVersion = Azure.Data.Tables.TableClientOptions.ServiceVersion.V2019_02_02) { }
        public enum ServiceVersion
        {
            V2019_02_02 = 1,
        }
    }
    public partial class TableServiceClient
    {
        protected TableServiceClient() { }
        public TableServiceClient(System.Uri endpoint, Azure.Data.Tables.TableClientOptions options = null) { }
        public TableServiceClient(System.Uri endpoint, Azure.Data.Tables.TablesSharedKeyCredential credential, Azure.Data.Tables.TableClientOptions options = null) { }
        public virtual Azure.Data.Tables.Models.TableResponse CreateTable(string tableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Data.Tables.Models.TableResponse> CreateTableAsync(string tableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteTable(string tableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteTableAsync(string tableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Data.Tables.Models.SignedIdentifier>> GetAccessPolicy(string table, int? timeout = default(int?), string requestId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Data.Tables.Models.SignedIdentifier>>> GetAccessPolicyAsync(string table, int? timeout = default(int?), string requestId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Data.Tables.TableClient GetTableClient(string tableName) { throw null; }
        public virtual Azure.Pageable<Azure.Data.Tables.Models.TableResponseProperties> GetTables(string select = null, string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.Data.Tables.Models.TableResponseProperties> GetTablesAsync(string select = null, string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response SetAccessPolicy(string table, int? timeout = default(int?), string requestId = null, System.Collections.Generic.IEnumerable<Azure.Data.Tables.Models.SignedIdentifier> tableAcl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> SetAccessPolicyAsync(string table, int? timeout = default(int?), string requestId = null, System.Collections.Generic.IEnumerable<Azure.Data.Tables.Models.SignedIdentifier> tableAcl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TablesSharedKeyCredential
    {
        public TablesSharedKeyCredential(string accountName, string accountKey) { }
        public string AccountName { get { throw null; } }
        public void SetAccountKey(string accountKey) { }
    }
}
namespace Azure.Data.Tables.Models
{
    public partial class AccessPolicy
    {
        public AccessPolicy(System.DateTimeOffset start, System.DateTimeOffset expiry, string permission) { }
        public System.DateTimeOffset Expiry { get { throw null; } set { } }
        public string Permission { get { throw null; } set { } }
        public System.DateTimeOffset Start { get { throw null; } set { } }
    }
    public partial class CorsRule
    {
        public CorsRule(string allowedOrigins, string allowedMethods, string allowedHeaders, string exposedHeaders, int maxAgeInSeconds) { }
        public string AllowedHeaders { get { throw null; } set { } }
        public string AllowedMethods { get { throw null; } set { } }
        public string AllowedOrigins { get { throw null; } set { } }
        public string ExposedHeaders { get { throw null; } set { } }
        public int MaxAgeInSeconds { get { throw null; } set { } }
    }
    public partial class GeoReplication
    {
        internal GeoReplication() { }
        public System.DateTimeOffset LastSyncTime { get { throw null; } }
        public Azure.Data.Tables.Models.GeoReplicationStatusType Status { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GeoReplicationStatusType : System.IEquatable<Azure.Data.Tables.Models.GeoReplicationStatusType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GeoReplicationStatusType(string value) { throw null; }
        public static Azure.Data.Tables.Models.GeoReplicationStatusType Bootstrap { get { throw null; } }
        public static Azure.Data.Tables.Models.GeoReplicationStatusType Live { get { throw null; } }
        public static Azure.Data.Tables.Models.GeoReplicationStatusType Unavailable { get { throw null; } }
        public bool Equals(Azure.Data.Tables.Models.GeoReplicationStatusType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Data.Tables.Models.GeoReplicationStatusType left, Azure.Data.Tables.Models.GeoReplicationStatusType right) { throw null; }
        public static implicit operator Azure.Data.Tables.Models.GeoReplicationStatusType (string value) { throw null; }
        public static bool operator !=(Azure.Data.Tables.Models.GeoReplicationStatusType left, Azure.Data.Tables.Models.GeoReplicationStatusType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LoggingSettings
    {
        public LoggingSettings(string version, bool delete, bool read, bool write, Azure.Data.Tables.Models.RetentionPolicy retentionPolicy) { }
        public bool Delete { get { throw null; } set { } }
        public bool Read { get { throw null; } set { } }
        public Azure.Data.Tables.Models.RetentionPolicy RetentionPolicy { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public bool Write { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct OdataMetadataFormat : System.IEquatable<Azure.Data.Tables.Models.OdataMetadataFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public OdataMetadataFormat(string value) { throw null; }
        public static Azure.Data.Tables.Models.OdataMetadataFormat ApplicationJsonOdataFullmetadata { get { throw null; } }
        public static Azure.Data.Tables.Models.OdataMetadataFormat ApplicationJsonOdataMinimalmetadata { get { throw null; } }
        public static Azure.Data.Tables.Models.OdataMetadataFormat ApplicationJsonOdataNometadata { get { throw null; } }
        public bool Equals(Azure.Data.Tables.Models.OdataMetadataFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Data.Tables.Models.OdataMetadataFormat left, Azure.Data.Tables.Models.OdataMetadataFormat right) { throw null; }
        public static implicit operator Azure.Data.Tables.Models.OdataMetadataFormat (string value) { throw null; }
        public static bool operator !=(Azure.Data.Tables.Models.OdataMetadataFormat left, Azure.Data.Tables.Models.OdataMetadataFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RequestMetrics
    {
        public RequestMetrics(bool enabled) { }
        public bool Enabled { get { throw null; } set { } }
        public bool? IncludeAPIs { get { throw null; } set { } }
        public Azure.Data.Tables.Models.RetentionPolicy RetentionPolicy { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class RetentionPolicy
    {
        public RetentionPolicy(bool enabled) { }
        public int? Days { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
    }
    public partial class SignedIdentifier
    {
        public SignedIdentifier(string id, Azure.Data.Tables.Models.AccessPolicy accessPolicy) { }
        public Azure.Data.Tables.Models.AccessPolicy AccessPolicy { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
    }
    public partial class StorageError
    {
        internal StorageError() { }
        public string Message { get { throw null; } }
    }
    public partial class StorageServiceProperties
    {
        public StorageServiceProperties() { }
        public System.Collections.Generic.IList<Azure.Data.Tables.Models.CorsRule> Cors { get { throw null; } set { } }
        public Azure.Data.Tables.Models.RequestMetrics HourMetrics { get { throw null; } set { } }
        public Azure.Data.Tables.Models.LoggingSettings Logging { get { throw null; } set { } }
        public Azure.Data.Tables.Models.RequestMetrics MinuteMetrics { get { throw null; } set { } }
    }
    public partial class StorageServiceStats
    {
        internal StorageServiceStats() { }
        public Azure.Data.Tables.Models.GeoReplication GeoReplication { get { throw null; } }
    }
    public partial class TableEntityQueryResponse
    {
        internal TableEntityQueryResponse() { }
        public string OdataMetadata { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IDictionary<string, object>> Value { get { throw null; } }
    }
    public partial class TableProperties
    {
        public TableProperties() { }
        public string TableName { get { throw null; } set { } }
    }
    public partial class TableQueryResponse
    {
        internal TableQueryResponse() { }
        public string OdataMetadata { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Data.Tables.Models.TableResponseProperties> Value { get { throw null; } }
    }
    public partial class TableResponse : Azure.Data.Tables.Models.TableResponseProperties
    {
        internal TableResponse() { }
        public string OdataMetadata { get { throw null; } }
    }
    public partial class TableResponseProperties
    {
        internal TableResponseProperties() { }
        public string OdataEditLink { get { throw null; } }
        public string OdataId { get { throw null; } }
        public string OdataType { get { throw null; } }
        public string TableName { get { throw null; } }
    }
}
namespace Azure.Data.Tables.Sas
{
    [System.FlagsAttribute]
    public enum AccountSasServices
    {
        Tables = 8,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SasIPRange : System.IEquatable<Azure.Data.Tables.Sas.SasIPRange>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SasIPRange(System.Net.IPAddress start, System.Net.IPAddress end = null) { throw null; }
        public System.Net.IPAddress End { get { throw null; } }
        public System.Net.IPAddress Start { get { throw null; } }
        public bool Equals(Azure.Data.Tables.Sas.SasIPRange other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Data.Tables.Sas.SasIPRange left, Azure.Data.Tables.Sas.SasIPRange right) { throw null; }
        public static bool operator !=(Azure.Data.Tables.Sas.SasIPRange left, Azure.Data.Tables.Sas.SasIPRange right) { throw null; }
        public static Azure.Data.Tables.Sas.SasIPRange Parse(string s) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum SasProtocol
    {
        None = 0,
        HttpsAndHttp = 1,
        Https = 2,
    }
    public partial class SasQueryParameters
    {
        public const string DefaultSasVersion = "2019-07-07";
        protected SasQueryParameters() { }
        protected SasQueryParameters(System.Collections.Generic.IDictionary<string, string> values) { }
        protected SasQueryParameters(string version, Azure.Data.Tables.Sas.AccountSasServices? services, Azure.Data.Tables.Sas.TableAccountSasResourceTypes? resourceTypes, Azure.Data.Tables.Sas.SasProtocol protocol, System.DateTimeOffset startsOn, System.DateTimeOffset expiresOn, Azure.Data.Tables.Sas.SasIPRange ipRange, string identifier, string resource, string permissions, string signature, string cacheControl = null, string contentDisposition = null, string contentEncoding = null, string contentLanguage = null, string contentType = null) { }
        public string CacheControl { get { throw null; } }
        public string ContentDisposition { get { throw null; } }
        public string ContentEncoding { get { throw null; } }
        public string ContentLanguage { get { throw null; } }
        public string ContentType { get { throw null; } }
        public static Azure.Data.Tables.Sas.SasQueryParameters Empty { get { throw null; } }
        public System.DateTimeOffset ExpiresOn { get { throw null; } }
        public string Identifier { get { throw null; } }
        public Azure.Data.Tables.Sas.SasIPRange IPRange { get { throw null; } }
        public string Permissions { get { throw null; } }
        public Azure.Data.Tables.Sas.SasProtocol Protocol { get { throw null; } }
        public string Resource { get { throw null; } }
        public Azure.Data.Tables.Sas.TableAccountSasResourceTypes? ResourceTypes { get { throw null; } }
        public Azure.Data.Tables.Sas.AccountSasServices? Services { get { throw null; } }
        public string Signature { get { throw null; } }
        public System.DateTimeOffset StartsOn { get { throw null; } }
        public string Version { get { throw null; } }
        protected static Azure.Data.Tables.Sas.SasQueryParameters Create(System.Collections.Generic.IDictionary<string, string> values) { throw null; }
        protected static Azure.Data.Tables.Sas.SasQueryParameters Create(string version, Azure.Data.Tables.Sas.AccountSasServices? services, Azure.Data.Tables.Sas.TableAccountSasResourceTypes? resourceTypes, Azure.Data.Tables.Sas.SasProtocol protocol, System.DateTimeOffset startsOn, System.DateTimeOffset expiresOn, Azure.Data.Tables.Sas.SasIPRange ipRange, string identifier, string resource, string permissions, string signature, string cacheControl = null, string contentDisposition = null, string contentEncoding = null, string contentLanguage = null, string contentType = null) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TableAccountSasBuilder
    {
        public TableAccountSasBuilder() { }
        public System.DateTimeOffset ExpiresOn { get { throw null; } set { } }
        public Azure.Data.Tables.Sas.SasIPRange IPRange { get { throw null; } set { } }
        public string Permissions { get { throw null; } }
        public Azure.Data.Tables.Sas.SasProtocol Protocol { get { throw null; } set { } }
        public Azure.Data.Tables.Sas.TableAccountSasResourceTypes ResourceTypes { get { throw null; } set { } }
        public Azure.Data.Tables.Sas.AccountSasServices Services { get { throw null; } set { } }
        public System.DateTimeOffset StartsOn { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public void SetPermissions(Azure.Data.Tables.Sas.TableAccountSasPermissions permissions) { }
        public void SetPermissions(string rawPermissions) { }
        public Azure.Data.Tables.Sas.SasQueryParameters ToSasQueryParameters(Azure.Data.Tables.TablesSharedKeyCredential sharedKeyCredential) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum TableAccountSasPermissions
    {
        All = -1,
        Read = 1,
        Write = 2,
        Delete = 4,
        List = 8,
        Add = 16,
        Create = 32,
        Update = 64,
    }
    [System.FlagsAttribute]
    public enum TableAccountSasResourceTypes
    {
        All = -1,
        Service = 1,
        Container = 2,
        Object = 4,
    }
    public partial class TableSasBuilder
    {
        public TableSasBuilder(string tableName) { }
        public System.DateTimeOffset ExpiresOn { get { throw null; } set { } }
        public string Identifier { get { throw null; } set { } }
        public Azure.Data.Tables.Sas.SasIPRange IPRange { get { throw null; } set { } }
        public string PartitionKeyEnd { get { throw null; } set { } }
        public string PartitionKeyStart { get { throw null; } set { } }
        public string Permissions { get { throw null; } }
        public Azure.Data.Tables.Sas.SasProtocol Protocol { get { throw null; } set { } }
        public string RowKeyEnd { get { throw null; } set { } }
        public string RowKeyStart { get { throw null; } set { } }
        public System.DateTimeOffset StartsOn { get { throw null; } set { } }
        public string TableName { get { throw null; } }
        public string Version { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public void SetPermissions(Azure.Data.Tables.Sas.TableSasPermissions permissions) { }
        public void SetPermissions(string rawPermissions) { }
        public Azure.Data.Tables.Sas.TableSasQueryParameters ToSasQueryParameters(Azure.Data.Tables.TablesSharedKeyCredential sharedKeyCredential) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum TableSasPermissions
    {
        All = -1,
        Read = 1,
        Add = 2,
        Update = 4,
        Delete = 8,
    }
    public sealed partial class TableSasQueryParameters : Azure.Data.Tables.Sas.SasQueryParameters
    {
        internal TableSasQueryParameters() { }
        public static new Azure.Data.Tables.Sas.TableSasQueryParameters Empty { get { throw null; } }
        public string EndPartitionKey { get { throw null; } set { } }
        public string EndRowKey { get { throw null; } set { } }
        public string StartPartitionKey { get { throw null; } set { } }
        public string StartRowKey { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
}
