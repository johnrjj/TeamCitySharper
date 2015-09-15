using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using TeamCitySharper.TeamCityModels;

namespace TeamCitySharper
{
    public class TeamCityClient
    {

        private readonly RestClient client;
        public TeamCityClient(TeamCityAccount account)
        {
            client = new RestClient(account.ServerUrl)
            {
                Authenticator = new HttpBasicAuthenticator(account.User, account.Password)
            };
        }

        public T Execute<T>(RestRequest request, HttpStatusCode expectedResponseCode) where T : new()
        {
            // Won't throw exception.
            var response = client.Execute<T>(request);

            ValidateResponse(response);

            return response.Data;
        }

        private static void ValidateResponse(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed || response.ErrorException != null || response.StatusCode == HttpStatusCode.BadRequest)
                throw new TeamCityApiException(string.Format("RestSharp response status: {0} - HTTP response: {1} - {2} - {3}", response.ResponseStatus, response.StatusCode, response.StatusDescription, response.Content));
        }

        public Projects GetProjects()
        {
            var request = new RestRequest()
            {
                Resource = ResourceUrls.Project(),
                RequestFormat = DataFormat.Json,
                Method = Method.GET
            };

            return Execute<Projects>(request, HttpStatusCode.OK);
        }

    }
}
