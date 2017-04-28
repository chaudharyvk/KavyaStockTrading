using System.Net;

namespace KavyaStockTrading.Models.AVDataServiceModel
{
    public class AvResponse
    {
        public HttpStatusCode StatusCode;
        public object JsonContent;
        public string ErrorMessage;
    }
}
