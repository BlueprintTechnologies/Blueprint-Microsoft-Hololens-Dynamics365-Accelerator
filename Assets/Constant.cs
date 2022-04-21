using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Constants
{
    public const string KeyVaultPrefix = "keyvault=";
    public const string CustomODataPath = "CustomODataPath";
    public const string ODataEndpoint = "ODataEndpoint";
    public const string MSHttpRequestMessage = "MS_HttpRequestMessage";
    public const string ActiveControllerPrefix = "Active";
    public const string ActiveMetadataControllerPrefix = "ActiveOdataMetadata";
    public const string FilterSuffix = ".filters";
    public const string PasswordKey = "password";
    public const string KeyLabel = "key";
    public const string ValueLabel = "value";
    public const string Bearer = "bearer";
    public const string Basic = "basic";
    public const string trueValue = "true";
    public const string flaseValue = "false";
    public const string WWWAuthenticate = "WWW - Authenticate";
    public const string AADAuthEndpoint = "AADAuthEndpoint";
    public const string Anonymous = ""; //"demonstrate@bpcs.com"; // for VM: @"bpcs\validate"
    public const string passwordEncryped = "encrypted";
    public const string clientAppIdName = "client:AppId";
    public const string clientAppKeyName = "client:AppKey";
    public const string serviceTenantName = "service:Tenant";
    public const string serviceAppIdName = "service:AppId";
    public const string serviceAppKeyName = "service:AppKey";

    public const string AppInsightsEnabledName = "ai:enabled";
    public const string AppInsightsKeysName = "ai:keys";
    public const string AppInsightsServerName = "ai:server";
    public const string AppServiceUsername = "AppServiceUsername";
    public const string AppServicePassword = "AppServicePassword";

    // Conduit authentication & authorization uri's
    public const string authenticationUriName = "connector:authenticationUri";
    public const string authenticationCredentialName = "connector:authenticationCredential";
    public const string authorizationName = "connector:authorization";
    public const string authorizationUriName = "connector:authorizationUri";
    public const string authorizationAADName = "AAD:authorization";
    public const string connectorTimeout = "connector:timeout";

    public const string COLLATE = "COLLATE Latin1_General_CS_AS";
    public const string LicenseUrlLabel = "licenseserver";

    public const string NTLM = "NTLM:";
    public const string TRACE = "TRACE";
    public const string DEBUG = "DEBUG";
    public const string INFO = "INFO";

    // SQL Functions
    public const string Func_endswith = "endswith";
    public const string Func_startswith = "startswith";
    public const string Func_substringof = "substringof";
    public const string Func_length = "length";
    public const string Func_indexof = "indexof";
    public const string Func_replace = "replace";
    public const string Func_substring = "substring";
    public const string Func_tolower = "tolower";
    public const string Func_toupper = "toupper";
    public const string Func_trim = "trim";
    public const string Func_concat = "concat";
    public const string Func_day = "day";
    public const string Func_month = "month";
    public const string Func_year = "year";
    public const string Func_hour = "hour";
    public const string Func_minute = "minute";
    public const string Func_second = "second";
    public const string Func_round = "round";
    public const string Func_floor = "floor";
    public const string Func_ceiling = "ceiling";
    public const string CustomLogicRequiredStart = "<CustomLogic>", CustomLogicRequiredEnd = "</CustomLogic>";

    // Metric Events
    public const string EventName_DefaultValue = "ConduitODataEvent";
    public const string EventName_Source = "source";
    public const string EventName_Action = "action";
    public const string EventName_Method = "method";
    public const string EventName_StartTime = "start";
    public const string EventName_Duration = "duration";
    public const string EventName_ResultCount = "result.count";
    public const string EventName_ResultColumnCount = "result.column.count";
    public const string EventName_ResultSize = "result.size";
    public const string EventName_PermissionUser = "authorization.user";
    public const string EventName_PermissionUserPwd = "authorization.pwd";
    public const string EventName_PermissionConnector = "authorization.connector";
    public const string EventName_PermissionDbConnString = "authorization.dbconnstring";
    public const string EventName_PermissionIsAuthorized = "authorization.isauthorized";
    public const string EventName_Url = "url";
    public const string EventName_Json = "json";
    public const string EventName_OAuth = "oauth";
    public const string EventName_Message = "message";
    public const string EventName_StackTrace = "stack";
    public const string EventName_Authorization = "authorization";

    // Methods
    public const string Method_GET = "GET";
    public const string Method_POST = "POST";
    public const string Method_PUT = "PUT";
    public const string Method_DELETE = "DELETE";

    // Tags
    public const string TAG_EntitySet = "EntitySet";
    public const string TAG_EntityType = "EntityType";
    public const string TAG_Property = "Property";
    public const string TAG_Name = "Name";
    public const string TAG_Type = "Type";
    public const string metadataFilter = "$metadata";
    public const string AADAuthUrlSeperator0 = "?resource=";
    public const string AADAuthUrlSeperator1 = "$";

}