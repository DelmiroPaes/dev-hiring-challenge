using System;
using System.Threading.Tasks;

namespace GitHubJsonQuery
{
    public class GitHubJsonQuery
    {
        private static readonly string apiVersion = "v3";

        public GitHubJsonQuery(string language)
        {
            Language = language;
        }

        public static string GetApiVersion()
        {
            return apiVersion;
        }

        public string Language { get; private set; }

        private static readonly string apiBaseAddress = "https://api.github.com";

        internal static string GetApiBaseAddress()
        {
            return apiBaseAddress;
        }

        private static readonly string apiBaseSearch = "/search/repositories?";

        internal static string GetApiBaseSearch()
        {
            return apiBaseSearch;
        }

        private static readonly int apiQueryMinStars = 10000;

        internal static int GetApiQueryMinStars()
        {
            return apiQueryMinStars;
        }

        private static readonly string apiSortCommand = "stars";

        internal static string GetApiSortCommand()
        {
            return apiSortCommand;
        }

        private static readonly string apiOrderCommand = "desc";

        internal static string GetApiOrderCommand()
        {
            return apiSortCommand;
        }

        private static readonly int apiPerPageItens = 5;

        internal static int GetApiPerPageItens()
        {
            return apiPerPageItens;
        }

        private static readonly int apiPages = 1;

        internal static int GetApiPages()
        {
            return apiPages;
        }

        internal static string GetQueryForLanguage(string language)
        {
            string queryForLanguage = apiBaseSearch + "q=" +
                                      HttpUtility.UrlEncode(apiSortCommand + ":>" + apiQueryMinStars.ToString()) +
                                      "+" +
                                      HttpUtility.UrlEncode("language:" + language) +
                                      "&sort=" + apiSortCommand +
                                      "&order=" + apiOrderCommand +
                                      "&per_page=" + apiPerPageItens.ToString() +
                                      "&page=" + apiPages.ToString();

            return queryForLanguage;
        }

        public async Task<string> RunQuery()
        {
            HttpResponseMessage httpResponseMessage = null;
            string queryResult = null;

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiBaseAddress);

                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("user-agent", "Nothing");

                // GET
                httpResponseMessage = await httpClient.GetAsync(GetQueryForLanguage(Language));
                queryResult = await httpResponseMessage.Content.ReadAsStringAsync();

                //Task<HttpResponseMessage> responseTask = await httpClient.GetAsync(GetQueryForLanguage(language));
                //responseTask.Wait(5000);

                //if (responseTask.StatusCode == HttpStatusCode.OK)
                //{
                //    queryResult = await responseTask.Content.ReadAsStringAsync();
                //}

                //public async Task<String> DownloadStringV1(String url)
                //{
                //    // good code
                //    var request = await HttpClient.GetAsync(url);
                //    var download = await request.Content.ReadAsStringAsync();
                //    return download;
                //}

                //if (responseTask.IsCompleted || responseTask.IsCompletedSuccessfully)
                //{
                //    //queryResultTask = await response.Content.ReadAsStringAsync().Result();
                //    //Task<string> queryResultTask = await response.Result.Content.ReadAsStringAsync();

                //    queryResult = await responseTask.Result.Content.ReadAsStringAsync();

                //    //Task<string> queryResultTask = await responseTask.Result.Content.ReadAsStringAsync();
                //    //queryResultTask.Wait(5000);
                //    //queryResult = queryResultTask.Result;

                //    //queryResultTask = queryResultTask.Result;
                //}

                //if (response.IsCompletedSuccessfully || response.IsCompleted)
                //{
                //    if (response.Result.IsSuccessStatusCode)
                //    {
                //        //Task<string> queryResult = response.Result.Content.ReadAsStringAsync();
                //        //return queryResult.Result;
                //        queryResult = response.Result.Content.ReadAsStringAsync().Result;
                //        return queryResult;
                //    }
                //}

                //
                // / GET
                // Task<HttpResponseMessage> response = httpClient.GetAsync(GetQueryForLanguage(language));
                //
                // if (response.IsCompletedSuccessfully || response.IsCompleted)
                //{
                //    if (response.Result.IsSuccessStatusCode)
                //    {
                //        //Task<string> queryResult = response.Result.Content.ReadAsStringAsync();
                //        //return queryResult.Result;
                //        queryResult = response.Result.Content.ReadAsStringAsync().Result;
                //        return queryResult;
                //    }
                //}
            }

            return queryResult;
        }
    }
}
