using BlazorApp2.Models;

namespace BlazorApp2.Services
{

        public interface IImageHttpRepo
        {
            Task<List<Image>> GetImages();

            Task<List<Image>> GetUngradedImages();

            Task<Image> GetImageById(int id);

            Task<HttpResponseMessage> EditImage(Image image);

            Task<HttpResponseMessage> DeleteImage(int id);
        }
 
}
