using Newtonsoft.Json;
using SpreedlyWebApp.Spreedly.SpreedlyModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpreedlyWebApp.Spreedly
{
    public class SpreedlyPaymentProcessor
    {
        private string ApiKey= ConfigurationManager.AppSettings["SpreedlyAPISecret"];
        private string EnvKey = ConfigurationManager.AppSettings["SpreedlyEnvKey"];
        private string GatewayToken = ConfigurationManager.AppSettings["SpreedlyGateway"];

        HttpClient hClient;
        
        public SpreedlyTransactionResponse spTransaction;
        public SpreedlyTransactionRequest spRequest;

        public async Task<SpreedlyTransactionResponse> SendTransaction(SpreedlyTransactionRequest request)
        {
            if (String.IsNullOrEmpty(ApiKey) || String.IsNullOrEmpty(EnvKey))
            {
                throw new KeyNotFoundException("Spreedly API or Environment key missing.");
            }

            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            spRequest = request;
            hClient = new HttpClient();
            hClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{EnvKey}:{ApiKey}")));

            string gatewayUrl = $"{"https:"}//core.spreedly.com/v1/gateways/{GatewayToken}/purchase.json";

            try
            {
                var content = JsonConvert.SerializeObject( new { transaction = request });
                HttpResponseMessage resp = await hClient.PostAsync(gatewayUrl, new StringContent(content, Encoding.UTF8, "application/json"));

                if (resp.IsSuccessStatusCode)
                {
                    string respBody = await resp.Content.ReadAsStringAsync();
                    spTransaction = JsonConvert.DeserializeObject<SpreedlyTransactionResponse>(respBody);
                }
                else
                {
                    string respBody = await resp.Content.ReadAsStringAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return spTransaction;
        }
    }
}