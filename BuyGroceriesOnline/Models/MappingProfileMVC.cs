using AutoMapper;
namespace BuyGroceriesOnline.Models
{
    public class MappingProfileMVC : Profile
    {
        public MappingProfileMVC()//constuctor
        {
            this.CreateMap<Product, ProductMini>();
        }
    }
}
