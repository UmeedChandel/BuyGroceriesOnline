using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyGroceriesOnline.Migrations
{
    public partial class seedmoredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 5, "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg", "https://www.bigbasket.com/media/uploads/p/l/251006_11-sprite-soft-drink-lime-flavoured.jpg", "Refreshing people since 1999, Sprite is known for its straightforward attitude. The brand strongly believes in removing all the unnecessary Bakwaas from your life so that you can chill for real.", "Sprite Soft Drink", "Carbonated Water, Sugar, Acidity Regulator (330, 331), Preservative (211). Contains Added Flavours (Natural Flavouring Substances)." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 115, "Fanta", 5, "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg", "https://www.bigbasket.com/media/uploads/p/l/251019_8-fanta-soft-drink-orange-flavoured.jpg", true, false, "Life is always fun with colourful energy, vibes and FANTA by your side. Known for its vibrant colour, tempting taste and tingling bubbles, FANTA lets your spirit free, thus encouraging you to have fun in life.", "Fanta Soft Drink", 35m, "Orange Flavoured, Refreshing, 750 ml Pet Bottle" },
                    { 116, "Thums Up", 5, "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg", "https://www.bigbasket.com/media/uploads/p/l/288927_8-thums-up-soft-drink.jpg", true, false, "Thums Up is well-known for its strong, fizzy flavor and its secure, mature and distinctively masculine attitude. This brand obviously seeks to divide the men from the boys. A glass soft drink goes well with any variety of food and any type of mood.", "Thums Up Soft Drink", 40m, "Carbonated Water, sugar, Acidity Regulator (338), Caffeine. Contains Permitted Natural Colour (150d) and Added Flavours (Natural, Nature - identical and Artificial Flavouring Substances)." },
                    { 117, "Fresho ", 1, "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg", "https://www.bigbasket.com/media/uploads/p/l/40022647-2_1-fresho-papaya-organically-grown.jpg", true, false, "Papayas reduce the risk of macular degeneration, a disease that affects the eyes as people age.They prevent asthma and cancer.Mashed papayas help in wound healing and preventing infections.", "Papaya", 40m, "Organically Grown, 1 pc (approx. 500 -1 kg)" },
                    { 118, "Fresho ", 1, "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg", "https://www.bigbasket.com/media/uploads/p/l/40023482-2_1-fresho-watermelon-organically-grown.jpg", true, false, "Watermelons have excellent hydrating properties with 90% water content.Rich in anti - oxidant flavonoids that protects against prostate,breast,colon,pancreatic and lung cancers.", "Watermelon", 45m, "Organically Grown (Loose), 1 pc (approx. 1 -3 kg)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114,
                columns: new[] { "CategoryId", "ImageThumbnailUrl", "ImageUrl", "LongDescription", "Name", "ShortDescription" },
                values: new object[] { 4, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", "Let the lemon-flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly. This refreshing beverage complements meals, and also, it gives you instant energy to sail through the hot summer days. Clean and Crisp Flavour", "Sprite Can", "Let the lemon - flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly." });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 113, "Coca-Cola ", 4, "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", true, false, "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.", "Coca-Cola Soft Drink Can", 31m, "Haldirams Aloo Bhujia is a authentic namkeen." });
        }
    }
}
