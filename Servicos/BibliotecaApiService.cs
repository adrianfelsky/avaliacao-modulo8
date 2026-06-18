using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicos
{
    public class BibliotecaApiService
    {
        private readonly HttpClient _httpClient;
        public BibliotecaApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<BibliotecaApiService?> BuscarDetalhesApiAsync(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                return null;

            string tituloFormatado = Uri.EscapeDataString(titulo);

            string url = $"https://openlibrary.org/search.json?title={tituloFormatado}";

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var resultado = JsonSerializer.Deserialize<BibliotecaApiService>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return resultado;
        }

    }
}
