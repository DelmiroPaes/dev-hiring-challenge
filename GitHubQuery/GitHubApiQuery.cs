/**********************************************************************************************//**
 * \file    GitHubApiQuery.cs.
 *
 * \brief   Implements the git hub API query class
 **************************************************************************************************/
using GitHub.Data.GitHubDataContexts;
using GitHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Web;

namespace GitHubQuery
{
    /**********************************************************************************************//**
     * \class   GitHubApiQuery
     *
     * \brief   A git hub API query.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class GitHubApiQuery
    {
        /** \brief   /** \brief   The API version */
        private string _apiVersion = "v3";
        /** \brief   /** \brief   The languages */
        private List<string> _languages = new List<string>();
        /** \brief   /** \brief   The query result string */
        private string _queryResultString = string.Empty;
        /** \brief   /** \brief   The milliseconds to wait */
        private int _millisecondsToWait = 100000;
        /** \brief   /** \brief   The API query minimum stars */
        private int _apiQueryMinStars = 10000;
        /** \brief   /** \brief   The API pages */
        private int _apiPages = 1;
        /** \brief   /** \brief   The API items per page */
        private int _apiItemsPerPage = 5;


        /**********************************************************************************************//**
         * \property    public string ApiVersion
         *
         * \brief   Gets or sets the API version
         *
         * \returns The API version.
         **************************************************************************************************/
        public string ApiVersion
        {
            get { return _apiVersion; }
            set { _apiVersion = value; }
        }


        /**********************************************************************************************//**
         * \property    public int MillisecondsToWait
         *
         * \brief   Gets or sets the milliseconds to wait
         *
         * \returns The milliseconds to wait.
         **************************************************************************************************/
        public int MillisecondsToWait
        {
            get { return _millisecondsToWait; }
            set { _millisecondsToWait = value; }
        }


        /**********************************************************************************************//**
         * \property    public int ApiQueryMinStars
         *
         * \brief   Gets or sets the API query minimum stars
         *
         * \returns The API query minimum stars.
         **************************************************************************************************/
        public int ApiQueryMinStars
        {
            get { return _apiQueryMinStars; }
            set { _apiQueryMinStars = value; }
        }


        /**********************************************************************************************//**
         * \property    public int ApiItemsPerPage
         *
         * \brief   Gets or sets the API items per page
         *
         * \returns The API items per page.
         **************************************************************************************************/
        public int ApiItemsPerPage
        {
            get { return _apiItemsPerPage; }
            set { _apiItemsPerPage = value; }
        }


        /**********************************************************************************************//**
         * \property    public int ApiPages
         *
         * \brief   Gets or sets the API pages
         *
         * \returns The API pages.
         **************************************************************************************************/
        public int ApiPages
        {
            get { return _apiPages; }
            set { _apiPages = value; }
        }


        /**********************************************************************************************//**
         * \fn  public GitHubApiQuery(List<string> languages)
         *
         * \brief   Constructor
         *
         * \author  Delmiro Paes
         *
         * \exception   ArgumentException   Thrown when one or more arguments have unsupported or illegal
         *                                  values.
         *
         * \param   languages   The languages.
         **************************************************************************************************/
        public GitHubApiQuery(List<string> languages)
        {
            if(languages == null || languages.Count == 0)
            {
                throw new ArgumentException("Não pode ser nulo ou vazio", nameof(languages));
            }

            _languages = languages;
        }


        /**********************************************************************************************//**
         * \fn  public GitHubApiQuery(string language)
         *
         * \brief   Constructor
         *
         * \author  Delmiro Paes
         *
         * \exception   ArgumentException   Thrown when one or more arguments have unsupported or illegal
         *                                  values.
         *
         * \param   language    The language.
         **************************************************************************************************/
        public GitHubApiQuery(string language)
        {
            if(string.IsNullOrWhiteSpace(language))
            {
                throw new ArgumentException("Não pode ser nulo ou vazio", nameof(language));
            }

            _languages.Add(language);
        }


        /**********************************************************************************************//**
         * \fn  public string GetApiVersion()
         *
         * \brief   Gets API version
         *
         * \author  Delmiro Paes
         *
         * \returns The API version.
         **************************************************************************************************/
        public string GetApiVersion()
        {
            return _apiVersion;
        }

        /** \brief   /** \brief   The API base address */
        private static readonly string apiBaseAddress = "https://api.github.com";


        /**********************************************************************************************//**
         * \fn  internal static string GetApiBaseAddress()
         *
         * \brief   Gets API base address
         *
         * \author  Delmiro Paes
         *
         * \returns The API base address.
         **************************************************************************************************/
        internal static string GetApiBaseAddress()
        {
            return apiBaseAddress;
        }

        /** \brief   /** \brief   The API base search */
        private static readonly string apiBaseSearch = "/search/repositories?";


        /**********************************************************************************************//**
         * \fn  public string GetApiBaseSearch()
         *
         * \brief   Gets API base search
         *
         * \author  Delmiro Paes
         *
         * \returns The API base search.
         **************************************************************************************************/
        public string GetApiBaseSearch()
        {
            return apiBaseSearch;
        }

        /** \brief   /** \brief   The API sort command */
        private static readonly string apiSortCommand = "stars";


        /**********************************************************************************************//**
         * \fn  public string GetApiSortCommand()
         *
         * \brief   Gets API sort command
         *
         * \author  Delmiro Paes
         *
         * \returns The API sort command.
         **************************************************************************************************/
        public string GetApiSortCommand()
        {
            return apiSortCommand;
        }

        /** \brief   /** \brief   The API order command */
        private static readonly string apiOrderCommand = "desc";


        /**********************************************************************************************//**
         * \fn  public string GetApiOrderCommand()
         *
         * \brief   Gets API order command
         *
         * \author  Delmiro Paes
         *
         * \returns The API order command.
         **************************************************************************************************/
        public string GetApiOrderCommand()
        {
            return apiSortCommand;
        }


        /**********************************************************************************************//**
         * \fn  private string GetQueryForLanguage(string language)
         *
         * \brief   Gets query for language
         *
         * \author  Delmiro Paes
         *
         * \param   language    The language.
         *
         * \returns The query for language.
         **************************************************************************************************/
        private string GetQueryForLanguage(string language)
        {
            string queryForLanguage = apiBaseSearch + "q=" +
                                      HttpUtility.UrlEncode(apiSortCommand + ":>" + ApiQueryMinStars.ToString()) +
                                      "+" +
                                      HttpUtility.UrlEncode("language:" + language) +
                                      "&sort=" + apiSortCommand +
                                      "&order=" + apiOrderCommand +
                                      "&per_page=" + ApiItemsPerPage.ToString() +
                                      "&page=" + ApiPages.ToString();

            return queryForLanguage;
        }


        /**********************************************************************************************//**
         * \fn  private async Task<string> RunQuery(string language)
         *
         * \brief   Executes the query operation
         *
         * \author  Delmiro Paes
         *
         * \exception   ArgumentException   Thrown when one or more arguments have unsupported or illegal
         *                                  values.
         *
         * \param   language    The language.
         *
         * \returns An asynchronous result that yields a string.
         **************************************************************************************************/
        private async Task<string> RunQuery(string language)
        {
            string queryResultString = String.Empty;

            if(string.IsNullOrWhiteSpace(language))
            {
                throw new ArgumentException("Não pode ser nulo o vazio", nameof(language));
            }
            else
            {
                if (false == CheckGitWebApiAccess())
                {
                    return queryResultString;
                }
            }

            using(HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiBaseAddress);
                httpClient.Timeout = TimeSpan.FromMilliseconds(MillisecondsToWait);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("user-agent", "Nothing");

                // GET
                //ERROR:  See https://stackoverflow.com/questions/10343632/httpclient-getasync-never-returns-when-using-await-async
                //HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(GetQueryForLanguage(language));
                //QueryResultString = await httpResponseMessage.Content.ReadAsStringAsync();

                // Solution 01.
                //HttpResponseMessage httpResponseMessage = Task.Run(() => httpClient.GetAsync(GetQueryForLanguage(language))).Result;
                //queryResultString = Task.Run(() => httpResponseMessage.Content.ReadAsStringAsync()).Result;

                // Solution 02.
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(GetQueryForLanguage(language)).ConfigureAwait(false);
                queryResultString = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }

            return queryResultString;
        }


        /**********************************************************************************************//**
         * \fn  public string RunQuery()
         *
         * \brief   Executes the query operation
         *
         * \author  Delmiro Paes
         *
         * \exception   TimeoutException    Thrown when a Timeout error condition occurs.
         *
         * \returns A string.
         **************************************************************************************************/
        public string RunQuery()
        {
            List<Item> Items = new List<Item>();
            string queryResultString = String.Empty;
            List<Tuple<string, Task<string>>> languageTaskTuples = new List<Tuple<string, Task<string>>>();

            try
            {
                foreach(string language in _languages)
                {
                    Tuple<string, Task<string>> tupleLanguageTask = new Tuple<string, Task<string>>(language, RunQuery(language));
                    languageTaskTuples.Add(tupleLanguageTask);
                }

                //
                // Slow but make me appear smart.
                // TODO: Use an auxiliary class.
                Task.WaitAll(languageTaskTuples.FindAll(x => x.Item2 != null).Select(x => x.Item2).ToArray());
            }
            catch(AggregateException ae)
            {
                bool timeout = false;

                if (ae.InnerExceptions.Count == 1 && ae.InnerExceptions[0].InnerException is TaskCanceledException)
                {
                    timeout = true;
                }
                else
                {
                    //
                    //TODO: Find a better way to do this. Remove Lambda for better test coverability.
                    //
                    ae.Handle(x =>
                    {
                        //
                        //  Put some errors as timeout error.
                        //
                        if (x is TimeoutException ||
                            x is TaskCanceledException ||
                            x is HttpRequestException ||
                            x is OperationCanceledException) // This we know how to handle.
                        {
                            timeout = true;
                            return true;
                        }

                        //TODO: Check this! TRY TEST.
                        return false;
                    });
                }

                if(timeout)
                {
                    throw new TimeoutException("****   From AggregateException   ***", ae);
                }
            }
            catch(Exception)
            {
                return string.Empty;
            }
            
            foreach(Tuple<string, Task<string>> languageTaskTuple in languageTaskTuples)
            {
                //  All or nothing.
                if (string.IsNullOrEmpty(languageTaskTuple.Item2.Result))
                {
                    return string.Empty;
                }

                GitHubQueryJsonResult gitHubQueryJsonResult = JsonConvert.DeserializeObject<GitHubQueryJsonResult>(languageTaskTuple.Item2.Result);

                Items.AddRange(gitHubQueryJsonResult.Items);

                queryResultString += languageTaskTuple.Item2.Result;
            }

            if (false == SetSqlServerItems(Items))
            {
                queryResultString = string.Empty;
            }

            return queryResultString;
        }


        /**********************************************************************************************//**
         * \fn  public bool SetSqlServerItems(List<Item> items = null)
         *
         * \brief   Sets SQL server items
         *
         * \author  Delmiro Paes
         *
         * \param   items   (Optional) The items.
         *
         * \returns True if it succeeds, false if it fails.
         **************************************************************************************************/
        public bool SetSqlServerItems(List<Item> items = null)
        {
            if(items == null || items.Count == 0)
            {
                return false;
            }
            else
            {
                //TODO: SQL Error, what to do?
                if(CheckSqlServerAccess() == false)
                {
                    return false;
                }
            }

            int workItems = 0;

            using(GitHubDataContext dbContext = new GitHubDataContext())
            {
                try
                {
                    dbContext.Configuration.AutoDetectChangesEnabled = false;

                    dbContext.ClearDatabase();

                    workItems = dbContext.SaveChanges();

                    foreach(Item item in items)
                    {
                        dbContext.Items.Add(item);
                    }

                    workItems = dbContext.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
                finally
                {
                    dbContext.Configuration.AutoDetectChangesEnabled = true;
                }
            }

            return true;
        }


        /**********************************************************************************************//**
         * \fn  public string GetJsonFromSql()
         *
         * \brief   Gets JSON from SQL
         *
         * \author  Delmiro Paes
         *
         * \returns The JSON from SQL.
         **************************************************************************************************/
        public string GetJsonFromSql()
        {
            string jsonResult = string.Empty;
            List<Item> items = new List<Item>();

            if(CheckSqlServerAccess() == false)
            {
                //TODO: SQL Error, what to do?
                return "";
            }

            using(GitHubDataContext dbContext = new GitHubDataContext())
            {
                try
                {
                    //TODO: Just speed this up with Sql store procedure.
                    items = dbContext.Items
                            .Join
                            (
                                dbContext.Items.GroupBy(g => new { g.Language })
                                .Select(c => new { Language = c.Key.Language, SUM = c.Sum(s => s.Stargazers_count) })
                                //TODO: Remove this, not necessary.
                                .OrderByDescending(obd => obd.SUM),
                                itemIn => itemIn.Language,
                                itemOuter => itemOuter.Language,
                                (itemOuter, itemIn) => new { itemOuter, itemIn.SUM }
                            )
                            .OrderByDescending(obd => obd.SUM)
                            .ThenByDescending(obd => obd.itemOuter.Stargazers_count)
                            .Select(s => s.itemOuter)
                            .Include("Owner")
                            .Include("License")
                            .ToList();

                    //TODO: Check items count = 0.
                    //  All local.
                    ADHCServiceJsonResult adhcServiceJsonResult = new ADHCServiceJsonResult();
                    int totalCount = 0;
                    adhcServiceJsonResult.total_count = 0;
                    adhcServiceJsonResult.incomplete_results = false;
                    adhcServiceJsonResult.LanguageItems = new List<LanguageItem>();
                    List<LanguageItem> languageItems = new List<LanguageItem>();
                    LanguageItem languageItem = new LanguageItem();

                    for(int iCount = 0; iCount < items.Count; ++iCount)
                    {
                        languageItem.Name = items[iCount].Language;
                        languageItem.TotalStars += items[iCount].Stargazers_count;
                        languageItem.TotalProjects++;
                        totalCount++;

                        if(iCount + 1 == items.Count)
                        {
                            languageItem.Items.Add(items[iCount]);
                            adhcServiceJsonResult.LanguageItems.Add(languageItem);
                            break;
                        }
                        else if(languageItem.Name != items[iCount + 1].Language)
                        {
                            languageItem.Items.Add(items[iCount]);
                            adhcServiceJsonResult.LanguageItems.Add(languageItem);
                            languageItem = new LanguageItem();
                        }
                        else
                        {
                            languageItem.Items.Add(items[iCount]);
                        }
                    }

                    adhcServiceJsonResult.incomplete_results = false;
                    adhcServiceJsonResult.total_count = totalCount;

                    jsonResult = JsonConvert.SerializeObject(adhcServiceJsonResult);
                }
                catch(Exception)
                {
                    return string.Empty;
                }
            }

            return jsonResult;
        }


        /**********************************************************************************************//**
         * \fn  public static bool CheckSqlServerAccess()
         *
         * \brief   Determines if we can check SQL server access
         *
         * \author  Delmiro Paes
         *
         * \returns True if it succeeds, false if it fails.
         **************************************************************************************************/
        public static bool CheckSqlServerAccess()
        {
            using(GitHubDataContext dbContext = new GitHubDataContext())
            {
                try
                {
                    dbContext.Database.Connection.Open();
                    dbContext.Database.Connection.Close();
                }
                catch(SqlException ex)
                {
                    return false;
                }
            }

            return true;
        }


        /**********************************************************************************************//**
         * \fn  public bool CheckGitWebApiAccess()
         *
         * \brief   Determines if we can check git web API access
         *
         * \author  Delmiro Paes
         *
         * \returns True if it succeeds, false if it fails.
         **************************************************************************************************/
        public bool CheckGitWebApiAccess()
        {
            if (false == CheckByPing(GetApiBaseAddress()))
            {
                return false;
            }
         
            using(Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                bool success = false;
                bool resturnVal = false;

                try
                {
                    IAsyncResult result = socket.BeginConnect(apiBaseAddress, 443, null, null);
                    success = result.AsyncWaitHandle.WaitOne(5000, false); // test the connection for 2 seconds
                    resturnVal = success;
                    //resturnVal = socket.Connected;

                    if (socket.Connected)
                    {
                        socket.Disconnect(true);
                    }
                }
                catch (Exception)
                {
                    // Do nothing
                    resturnVal = false;
                }

                socket.Dispose();

                return resturnVal;
            }
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

//public static bool CheckByPing(string apiBaseAddress, int timeOut = 2000)
//{
//    bool pingResult = false;
//    Uri uri = new Uri(apiBaseAddress);

//    System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

//    try
//    {
//        System.Net.NetworkInformation.PingReply result = ping.Send(uri.Host, timeOut);
//        pingResult = result.Status == System.Net.NetworkInformation.IPStatus.Success;
//    }
//    catch (Exception)
//    {
//        //  Ignore. Just server access fault.
//    }

//    return pingResult;
//}

//protected void Page_Load(object sender, EventArgs e)
//{
//    try
//    {
//        System.Net.WebClient client = new System.Net.WebClient();
//        string result = client.DownloadString("http://www.example.com/api/TestMethod");
//    }
//    catch (System.Net.WebException)
//    {
//        //do something here to make the site unusable, e.g:
//        //myContent.Visible = false;
//        //myErrorDiv.Visible = true;
//    }

//}