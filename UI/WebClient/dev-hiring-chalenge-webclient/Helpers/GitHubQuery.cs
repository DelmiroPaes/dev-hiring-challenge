/**********************************************************************************************//**
 * \file    Helpers\GitHubQuery.cs.
 *
 * \brief   Implements the git hub query class
 **************************************************************************************************/
using GitHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Web.UI;

namespace dev_hiring_chalenge_webclient.Helpers
{
    /**********************************************************************************************//**
     * \class   GitHubQuery
     *
     * \brief   A git hub query.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class GitHubQuery
    {
        /**********************************************************************************************//**
         * \fn  public ADHCServiceJsonResult RunQuery()
         *
         * \brief   Executes the query operation
         *
         * \author  Delmiro Paes
         *
         * \returns An ADHCServiceJsonResult.
         **************************************************************************************************/
        public ADHCServiceJsonResult RunQuery()
        {
            ADHCServiceJsonResult adhcServiceJsonResult = new ADHCServiceJsonResult();
            string urlGitHubBridgeWebAPI = string.Empty;
            bool isRunningOnAzure = false;

            //TODO: Replace GitHubBridgeWebAPI by ADHCServiceJsonResult.
            isRunningOnAzure = ConfigurationManager.AppSettings["IsRunningOnAzure"] == "true";
            urlGitHubBridgeWebAPI = ConfigurationManager.AppSettings["GitHubBridgeWebAPI"];

            if(string.IsNullOrEmpty(urlGitHubBridgeWebAPI))
            {
                return adhcServiceJsonResult;
            }
            else if (!isRunningOnAzure)
            {
                if (CheckByPing(urlGitHubBridgeWebAPI, 1000) == false)
                {
                    return null;
                }
            }

            //TODO: Create a test for servive offline.
            using(HttpClient httpClient = new HttpClient())
            {
                string queryResultString = string.Empty;

                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("user-agent", "Nothing");

                try
                {
                    //  Just another way to query a URL.
                    if(string.IsNullOrEmpty(queryResultString = Task
                        .Run(() => httpClient.GetStringAsync(urlGitHubBridgeWebAPI))
                        .Result))
                    {
                        //  Just for fun, It's not a crime! Is it?
                        goto RunQueryEnd;
                    }

                    adhcServiceJsonResult = JsonConvert.DeserializeObject<ADHCServiceJsonResult>(queryResultString);
                }
                catch(Exception)
                {
                    adhcServiceJsonResult = null;
                }
            }

            RunQueryEnd:;

            return adhcServiceJsonResult;
        }


        /**********************************************************************************************//**
         * \fn  public static bool CheckByPing(string apiBaseAddress, int timeOut = 2000)
         *
         * \brief   Check by ping
         *
         * \author  Delmiro Paes
         *
         * \exception   PingException   Thrown when a Ping error condition occurs.
         *
         * \param   apiBaseAddress  The API base address.
         * \param   timeOut         (Optional) The time out.
         *
         * \returns True if it succeeds, false if it fails.
         **************************************************************************************************/
        public static bool CheckByPing(string apiBaseAddress, int timeOut = 2000)
        {
            bool pingResult = false;
            Ping pinger = null;

            if (string.IsNullOrWhiteSpace(apiBaseAddress))
            {
                return false;
            }

            UriHostNameType uriHostNameType = Uri.CheckHostName(apiBaseAddress);    //UriHostNameType.Dns

            // type: http://localhost:9000/v1/xyz...
            if (uriHostNameType == UriHostNameType.Unknown)
            {
                //trying get it as URI.
                Uri uri = new Uri(apiBaseAddress);
                apiBaseAddress = new Uri(apiBaseAddress).Host;

                uriHostNameType = Uri.CheckHostName(apiBaseAddress);

                if (uriHostNameType == UriHostNameType.Dns)
                {
                    IPAddress[] ipAddress = Dns.GetHostAddresses(apiBaseAddress);
                    apiBaseAddress = ipAddress[0].ToString();
                }
            }

            try
            {
                if (timeOut < 1)
                {
                    throw new PingException("Timeout do ping deve ser superior a 0 ms.");
                }

                pinger = new Ping();
                PingReply reply = pinger.Send(apiBaseAddress, timeOut);
                pingResult = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                pingResult = false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingResult;
        }
    }
}