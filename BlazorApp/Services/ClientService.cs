using BlazorApp.Entities;
using System.Net.Http.Json;

namespace BlazorApp.Services
{
    public class ClientService
    {
        private readonly HttpClient _httpClient;

        public ClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Client>> GetClientsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7275/api/Client");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Client>>();
                }
                else
                {
                    // Handle non-success status code (e.g., 404, 500)
                    throw new Exception($"Error retrieving clients: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Log the error and rethrow or handle appropriately
                throw new Exception("An error occurred while retrieving clients.", ex);
            }
        }

        public async Task<Client> GetClientAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://localhost:7275/api/Client/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Client>();
                }
                else
                {
                    // Handle non-success status code (e.g., 404, 500)
                    throw new Exception($"Error retrieving client with ID {id}: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the client.", ex);
            }
        }

        public async Task CreateClientAsync(Client client)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7275/api/Client", client);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error creating client: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the client.", ex);
            }
        }

        public async Task UpdateClientAsync(int id, Client client)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"https://localhost:7275/api/Client/{id}", client);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error updating client with ID {id}: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the client.", ex);
            }
        }

        public async Task DeleteClientAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"https://localhost:7275/api/Client/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error deleting client with ID {id}: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the client.", ex);
            }
        }
    }
}
