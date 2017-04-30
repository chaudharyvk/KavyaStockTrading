using System.Net;

namespace MarketDataAPI.AVDataServiceModel
{
    public class AvResponse
    {
        public HttpStatusCode StatusCode;
        public object JsonContent;
        public string ErrorMessage;
    }
}
