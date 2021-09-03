using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.Services
{
    public class SignatureReaderService
    {
        private readonly HttpClient _httpClient;

        public SignatureReaderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Models.Signature> GetSignatureAsync(string company)
        {
            var signature = await _httpClient.GetFromJsonAsync<Models.Signature>($"settings/{company}.json");
            signature.SetCompanyFolder(company.ToLower());
            return signature;
        }

    }
}
