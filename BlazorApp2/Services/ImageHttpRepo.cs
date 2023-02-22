using BlazorApp2.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace BlazorApp2.Services
{
    public class ImageHttpRepo : IImageHttpRepo
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        public ImageHttpRepo(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<HttpResponseMessage> DeleteImage(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync("Images/" + id);
            return response;
        }

        public async Task<HttpResponseMessage> EditImage(Image image)
        {
            var imageToSend = JsonSerializer.Serialize(image);
            var requestContent = new StringContent(imageToSend, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("Images/" + image.Id, requestContent);

            return response;
        }

        public async Task<List<Image>> GetImages()
        {
            var response = await _client.GetAsync("Images");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var images = JsonSerializer.Deserialize<List<Image>>(content, _options);
            return images;
        }

        public async Task<List<Image>> GetUngradedImages()
        {
            var response = await _client.GetAsync("Images/ungraded");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var images = JsonSerializer.Deserialize<List<Image>>(content, _options);
            return images;
        }




        public async Task<Image> GetImageById(int id)
        {
            var response = await _client.GetAsync("Images/" + id);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var image = JsonSerializer.Deserialize<Image>(content, _options);
            return image;
        }
    }
}
