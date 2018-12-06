using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rdvb.RP.Lab
{
    class RpCall
    {
        public static async Task GetSoapMessageAsync()
        {
            var operationHistoryRequest = new OperationHistoryRequest() { Barcode = "", MessageType = 0, Language = "RUS" };
            var authorizationHeader = new AuthorizationHeader() { login = "", password = "" };
            authorizationHeader.mustUnderstand = "1";

            var client = new OperationHistory12Client();

            var resp = await client.getOperationHistoryAsync(operationHistoryRequest, authorizationHeader);

            var res = JsonConvert.SerializeObject(resp.OperationHistoryData, Formatting.Indented);
            Console.WriteLine(res);
        }
    }
}
