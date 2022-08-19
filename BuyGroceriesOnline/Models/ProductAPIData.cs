using Newtonsoft.Json;

namespace BuyGroceriesOnline.Models
{
    public static class ProductAPIData
    {
        public static async Task<IEnumerable<Product>> GetApiData(string ApiAddress)
        {
            IEnumerable<Product> products = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiAddress))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<IEnumerable<Product>>(apiResponse);
                }
            }
            return products;
        }

        public static async Task<IEnumerable<Category>> GetCategoryApiData(string ApiAddress)
        {
            IEnumerable<Category> categories = new List<Category>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(ApiAddress))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(apiResponse);
                }
            }
            return categories;
        }
    }
}
