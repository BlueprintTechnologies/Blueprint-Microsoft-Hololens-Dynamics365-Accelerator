using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[System.Serializable]
public class AuthResponse
{
    public string token_type;
    public string expires_in;
    public string ext_expires_in;
    public string expires_on;
    public string not_before;
    public string resource;
    public string access_token;


    public static AuthResponse CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<AuthResponse>(jsonString);
    }

    // sample input:
    //{"token_type":"Bearer","expires_in":"3599","ext_expires_in":"0","expires_on":"1536026506","not_before":"1536022606","resource":"https://bpcs.crm.dynamics.com","access_token":"eyJ0..."}
}

[System.Serializable]
public class DataResponse
{
    public string context;
    public CRMAccount[] value;
    
    public static DataResponse CreateFromJSON(string jsonString)
    {
        var json = jsonString.Replace("@odata.", "");
        var obj = JsonUtility.FromJson<DataResponse>(json);
        return obj;
    }

    // sample input
    //{
    // "@odata.context":"https://bpcs.crm.dynamics.com/api/data/v9.0/$metadata#accounts",
    // "value":[{"@odata.etag":"W/\"1146759\"","address2_addresstypecode":1,"merged":false,"statecode":0,"numberofemployees":12000,"address1_composite":"601 Union St, Seattle, WA 98101","name":"BlackRock","opendeals":0,"modifiedon":"2018-08-29T17:23:25Z","_owninguser_value":"55985cc1-5708-4e47-8af9-95b44abe176f","openrevenue_state":1,"donotpostalmail":false,"accountratingcode":1,"marketingonly":false,"revenue_base":12345678.0000,"preferredcontactmethodcode":1,"_ownerid_value":"55985cc1-5708-4e47-8af9-95b44abe176f","customersizecode":1,"openrevenue_date":"2018-09-03T13:06:58Z","openrevenue_base":0.0000000000,"businesstypecode":1,"donotemail":false,"address2_shippingmethodcode":1,"revenue":12345678.0000,"address2_freighttermscode":1,"statuscode":1,"createdon":"2018-08-07T20:14:01Z","msdyn_travelchargetype":690970003,"opendeals_state":1,"openrevenue":0.0000000000,"donotsendmm":false,"donotfax":false,"donotbulkpostalmail":false,"versionnumber":1146759,"address1_line1":"601 Union St, Seattle, WA 98101","address1_addressid":"c16696c8-fc76-45cb-99fb-0055c2059347","creditonhold":false,"telephone1":"(206) 613-6700","donotphone":false,"_transactioncurrencyid_value":"32602f51-2c93-e811-a96d-000d3a33bfb5","accountid":"6bcb4f66-7e9a-e811-a952-000d3a3ab6b4","donotbulkemail":false,"exchangerate":1.0000000000,"_modifiedby_value":"55985cc1-5708-4e47-8af9-95b44abe176f","followemail":true,"shippingmethodcode":1,"_createdby_value":"55985cc1-5708-4e47-8af9-95b44abe176f","territorycode":1,"msdyn_taxexempt":false,"participatesinworkflow":false,"accountclassificationcode":1,"_owningbusinessunit_value":"f7dce616-1f93-e811-a96d-000d3a33bfb5","address2_addressid":"0ad6fa7b-711b-405c-9a14-da011b1fd427","opendeals_date":"2018-09-03T13:06:58Z","address2_line1":null,"address1_telephone1":null,"address1_postofficebox":null,"marketcap":null,"sic":null,"address1_name":null,"emailaddress3":null,"address2_county":null,"address1_line2":null,"timespentbymeonemailandmeetings":null,"yominame":null,"msdyn_workorderinstructions":null,"address2_longitude":null,"ownershipcode":null,"timezoneruleversionnumber":null,"_msdyn_serviceterritory_value":null,"msdyn_externalaccountid":null,"primarysatoriid":null,"_masterid_value":null,"address1_telephone2":null,"address2_fax":null,"_slaid_value":null,"aging60_base":null,"accountcategorycode":null,"entityimage":null,"msdyn_taxexemptnumber":null,"msdyn_travelcharge_base":null,"emailaddress1":null,"address1_latitude":null,"tickersymbol":null,"customertypecode":null,"_msdyn_salestaxcode_value":null,"address2_name":null,"accountnumber":null,"address1_stateorprovince":null,"address1_line3":null,"stageid":null,"importsequencenumber":null,"paymenttermscode":null,"fax":null,"address2_line3":null,"address2_utcoffset":null,"_modifiedonbehalfby_value":null,"utcconversiontimezonecode":null,"ftpsiteurl":null,"stockexchange":null,"address2_telephone3":null,"_owningteam_value":null,"aging60":null,"_defaultpricelevelid_value":null,"address1_telephone3":null,"aging30":null,"entityimage_url":null,"sharesoutstanding":null,"address2_latitude":null,"preferredappointmenttimecode":null,"address2_composite":null,"aging90_base":null,"industrycode":null,"_originatingleadid_value":null,"address1_city":null,"description":null,"address2_stateorprovince":null,"overriddencreatedon":null,"address1_country":null,"_slainvokedid_value":null,"address1_primarycontactname":null,"onholdtime":null,"_createdbyexternalparty_value":null,"traversedpath":null,"processid":null,"_createdonbehalfby_value":null,"_modifiedbyexternalparty_value":null,"aging90":null,"address2_postalcode":null,"address1_shippingmethodcode":null,"entityimage_timestamp":null,"address1_upszone":null,"address2_primarycontactname":null,"msdyn_travelcharge":null,"primarytwitterid":null,"_preferredserviceid_value":null,"address2_postofficebox":null,"address2_city":null,"_primarycontactid_value":null,"address1_freighttermscode":null,"address1_longitude":null,"telephone2":null,"address1_addresstypecode":null,"lastusedincampaign":null,"_preferredsystemuserid_value":null,"creditlimit_base":null,"telephone3":null,"preferredappointmentdaycode":null,"websiteurl":null,"address2_telephone1":null,"_preferredequipmentid_value":null,"creditlimit":null,"lastonholdtime":null,"address2_line2":null,"entityimageid":null,"aging30_base":null,"_territoryid_value":null,"address1_county":null,"address1_fax":null,"_msdyn_billingaccount_value":null,"marketcap_base":null,"address2_upszone":null,"address2_country":null,"address1_utcoffset":null,"emailaddress2":null,"_parentaccountid_value":null,"_msdyn_preferredresource_value":null,"address2_telephone2":null,"address1_postalcode":null}]
    //}
}

[System.Serializable]
public class CRMAccount
{
    public string etag;
    public string address2_addresstypecode;
    public string numberofemployees;
    public string revenue;
    public string name;
    public string address1_composite;
    public string telephone1;

}


public class Utility
{
    public static string GetData()
    {
        var data = "";  //data = System.DateTime.Now.ToLongTimeString();

        var aadInstance = "https://login.microsoftonline.com/{0}/oauth2/token";
        var clientId = "97d1b795-4af5-469f-9d76-458c85aa6833";
        var clientSecret = "9jIOFrgXcTzFlGSSVQEwVzuAb04mbp9mgerm3CzWBhA=";
        var resource = ""; //enter the root dynamics url here i.e bpcs-sandbox.crm.dynamics.com
        var tenant = "";//enter tenant here i.e bpcs.com;
        var authority = "https://login.microsoftonline.com/" + tenant;

        var token = GetBearerToken(
                aadInstance,
                "",
                tenant,
                clientId,
                clientSecret,
                resource
            );
        
        var uri = ""; //enter search URI here i.e. https://bpcs-sandbox.crm.dynamics.com/api/data/v9.0/accounts/?$filter=name eq 'BlackRock'
        var method = "GET";
        var contentType = "";
        var header = "";
        var userAgent = "";
        var body = "";
        var authorization = "";

        authorization = token;

        data = WebRequest(uri, method, contentType, authorization, "", "", header, userAgent, body);

        var crmAccounts = DataResponse.CreateFromJSON(data).value;
        var acc = crmAccounts[0];
        data = 
            "Name: " + acc.name + Environment.NewLine +
            "Employees: " + acc.numberofemployees + Environment.NewLine +
            "Revenue: " + Math.Round(Convert.ToDecimal(acc.revenue), 2).ToString() + Environment.NewLine + 
            "Tel: " + acc.telephone1 + Environment.NewLine +
            "Address: " + acc.address1_composite + Environment.NewLine;

        return data;
        
    }

    public static string GetDataTest()
    {
        var data = "";  //data = System.DateTime.Now.ToLongTimeString();

        var uri = "https://172.217.14.238"; // "http://www.google.com";
        var method = "GET";
        var contentType = "";
        var header = "";
        var userAgent = "";
        var body = "";
        var authorization = "";

        data = WebRequest(uri, method, contentType, authorization, "", "", header, userAgent, body);

        return data;
    }

    public static string GetBearerToken(string authority, // For example: "https://login.microsoftonline.com/{0}/oauth2/token" or "https://bpcslicense.azurewebsites.net/token"
                                        string credential, // For AAD, you can leave it empty. For Non-AAD, example: grant_type=password&username=testuser@test.com&password=password1
                                        string clientTenant = "", // For example: "bpcs.com"
                                        string clientAppId = "", // For example: "f335930b-73a5-4bc6-b1ca-de3749619ad2" (App Conduit)
                                        string clientAppKey = "", // For example: "p2TyIDbRTkSPDSTkBIc5170LsE4LaDXCIXj56Ovv5FM=" (App Conduit)
                                        string serviceAppId = "") // For example: "https://conduitodata.azurewebsites.net" (App ConduitOData)
    {
        var uri = authority.Contains("{0}") ? String.Format(authority, clientTenant) : authority;
        var method = Constants.Method_POST;
        var contentType = "";
        var authorization = "";
        var header = "";
        var userAgent = "";
        var body = !string.IsNullOrEmpty(credential) ? credential : String.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&resource={2}", clientAppId, clientAppKey, serviceAppId);
        
        var response = WebRequest(uri, method, contentType, authorization, "", "", header, userAgent, body);
                
        var json = AuthResponse.CreateFromJSON(response);
        var token = json.token_type + " " + json.access_token;
        
        return token;
    }
    
    public static string WebRequest(string uri,
                                    string method,
                                    string contentType,
                                    string authorization,
                                    string userName, string password, // Windows Integrated (format: "NTLM:bpcs\validate") or Basic (format: "user" or "bpcs\validate")
                                    string header,
                                    string userAgent,
                                    string body)
    {
        var response = "";

        try
        {
            var urlString = Convert.ToString(uri);
            var webRequest = System.Net.WebRequest.Create(urlString);

            if (webRequest != null)
            {
                if (string.IsNullOrEmpty(authorization))
                {
                    if (!string.IsNullOrEmpty(userName))
                    {
                        if (!userName.StartsWith(Constants.NTLM))
                        {
                            // basic auth
                            string encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(userName + ":" + password));
                            authorization = "Basic " + encoded;
                        }
                        else  // userName format: NTLM:bpcs\validate
                        {
                            userName = userName.Remove(0, Constants.NTLM.Length);

                            /* Windows Auth */
                            string domain = "";
                            string[] temp = userName.Split('\\');
                            if (temp.Length > 1)
                            {
                                userName = temp[1];
                                domain = temp[0];
                            }

                            CredentialCache cache = new CredentialCache();
                            cache.Add(new Uri(uri),
                                       string.IsNullOrEmpty(domain) ? "Basic" : "Negotiate",
                                       string.IsNullOrEmpty(domain) ? new NetworkCredential(userName, password) : new NetworkCredential(userName, password, domain));
                            webRequest.Credentials = cache;
                        }
                    }
                }

                webRequest.Method = method; // POST or GET
                webRequest.Timeout = 60000;
                if (!String.IsNullOrEmpty(contentType))
                {
                    webRequest.ContentType = Convert.ToString(contentType); // "application/json";
                }

                if (!String.IsNullOrEmpty(authorization)) webRequest.Headers.Add(HttpRequestHeader.Authorization, authorization);

                if (!String.IsNullOrEmpty(header))
                {
                    char[] separatingChars = { '|' };
                    string[] headers = header.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
                    foreach (string h in headers)
                    {
                        webRequest.Headers.Add(h);
                    }
                }

                if (!String.IsNullOrEmpty(userAgent))
                {
                    ((HttpWebRequest)webRequest).UserAgent = userAgent;
                }

                if (!String.IsNullOrEmpty(body))
                {
                    byte[] postByteArray = Encoding.UTF8.GetBytes(body);
                    Stream dataStream = webRequest.GetRequestStream();
                    dataStream.Write(postByteArray, 0, postByteArray.Length);
                    dataStream.Close();
                }

                ServicePointManager.DnsRefreshTimeout = 0;
                //ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.SystemDefault; //.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback
                (
                   delegate { return true; }
                );

                using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                    {
                        response = sr.ReadToEnd();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // throw ex;

            response = ex.Message;
        }

        return response;
    }
}

