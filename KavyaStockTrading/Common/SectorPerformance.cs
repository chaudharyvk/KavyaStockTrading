﻿
using KavyaStockTrading.Models.AVDataServiceModel;
using RestSharp;

namespace KavyaStockTrading.Common
{
    public class SectorPerformance : AvService
    {
        private const string DefaultFunction = "SECTOR";

        public SectorPerformance(string apiKey, int timeout = Constants.DefaultTimeout) : base (apiKey, timeout)
        {
        }

        public AvResponse Get(string function = DefaultFunction)
        {
            var request = new RestRequest(Constants.ApiRequestPath)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddParameter("function", function);
            request.AddParameter("apikey", ApiKey);

            return Client.GetAvResponse(request, Timeout);
        }
    }
}
