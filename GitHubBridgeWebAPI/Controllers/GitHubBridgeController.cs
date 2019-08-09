/**********************************************************************************************//**
 * \file    Controllers\GitHubBridgeController.cs.
 *
 * \brief   Implements the git hub bridge controller class
 **************************************************************************************************/
using GitHubQuery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Web.Http;

namespace GitHubBridgeWebAPI.Controllers
{
    /**********************************************************************************************//**
     * \class   GitHubBridgeController
     *
     * \brief   A controller for handling git hub bridges.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class GitHubBridgeController : ApiController
    {
        /**********************************************************************************************//**
         * \fn  public HttpResponseMessage GitHubQuery()
         *
         * \brief   http://localhost:5458/v1/GitHubBridge/GitHubQuery
         *
         * \author  Delmiro Paes
         *
         * \returns A HttpResponseMessage.
         **************************************************************************************************/
        [Route("v1/GitHubBridge/GitHubQuery")]
        [HttpGet]
        public HttpResponseMessage GitHubQuery()
        {
            // arrange
            string jsonResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = null;

            //Requester info - Just to log - Later a cache control may be implemented.
            //var ip = HttpRequestMessageExtensions.GetClientIpAddress(this.Request);

            // act
            try
            {
                gitHubApiQuery =
                    new GitHubApiQuery(new List<string>(new string[] {"Java", "C", "Python", "C++", "C#"}));
                gitHubApiQuery.ApiItemsPerPage = 5;
                gitHubApiQuery.ApiPages = 1;

                gitHubApiQuery.RunQuery();

                jsonResult = gitHubApiQuery.GetJsonFromSql();
            }
            catch (FileLoadException)
            {
                // Ignore - Debug exception.
            }
            catch(Exception)
            {
                // Serviço não está ativo.
                //throw new Exception(ex.Message, ex);
                return null;
            }

            HttpResponseMessage resp = new HttpResponseMessage { Content = new StringContent(jsonResult, System.Text.Encoding.UTF8, "application/json") };

            return resp;
        }

        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}