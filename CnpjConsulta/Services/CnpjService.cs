using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class CnpjService
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "https://receitaws.com.br/v1/cnpj/";

    public CnpjService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CnpjResponse?> GetCnpjDataAsync(string cnpj)
    {
        if (cnpj.Length != 14)
            throw new ArgumentException("CNPJ deve ter 14 dígitos.");

        var response = await _httpClient.GetAsync($"{BaseUrl}{cnpj}");

        if (!response.IsSuccessStatusCode)
            return null;

        var json = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true 
        };

        return JsonSerializer.Deserialize<CnpjResponse>(json, options);
    }
}