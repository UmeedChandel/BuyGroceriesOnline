using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuyGroceriesOnline.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruits", "Fruits are a rich source of vitamins, minerals, fibres and proteins. We should eat fresh fruits to keep ourselves healthy. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. Fruit is the sweet, fleshy, edible part of a plant. It generally contains seeds. Fruits are usually eaten raw, although some varieties can be cooked. They come in a wide variety of colours, shapes and flavours. Common types of fruits that are readily available include:" },
                    { 2, "Vegetables", "Vegetables contain many vitamins and minerals that are good for your health. These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid. Folic acid may reduce blood levels of homocysteine, a substance that may be a risk factor for coronary heart disease. Vegetables and fruit contain phytochemicals, or plant chemicals. These biologically active substances can help to protect you from some diseases. Scientific research shows that if you regularly eat lots of fruit and vegetables, you have a lower risk of: Type 2 diabetes, Stroke, Heart(cardiovascular) disease – when fruits and vegetables are eaten as food, not taken as supplements, Cancer – some forms of cancer, High blood pressure(hypertension). Vegetable is a broad term that refers to the edible parts of plants, which are usually their leaves, roots, fruits, or seeds. Vegetables are a staple food across the world and are a fundamental part of modern agriculture. Since they’re low in calories but high in nutrients, most health experts recommend that you consume vegetables daily. There’s a scientific consensus that a balanced, rotating diet of different varieties of vegetables is one of the best ways to source nutrients from your food starting at a young age. Vegetables are full of essential vitamins, minerals, and antioxidants that provide many important health benefits to your body. For instance, carrots are known for being very high in vitamin A, which plays an important role in eye health, as you grow older. Vegetables are a good source of dietary fiber, a type of carbohydrate that helps pass food through your digestive system. Studies show that fiber may also improve vitamin and mineral absorption in the body, which could potentially raise your daily energy levels." },
                    { 3, "Cereals", "Cheese cake" },
                    { 4, "Snacks Store", "Seasonal Pies" },
                    { 5, "Beverages", "Cream Pies" },
                    { 6, "Cleaning & Household", "Cream Pies" },
                    { 7, "Beauty & Makeup", "Cream Pies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "Unbranded", 1, "https://media.istockphoto.com/photos/red-cherry-plum-with-green-leaves-isolated-on-white-background-picture-id687478414?k=20&m=687478414&s=612x612&w=0&h=eI2g4RbgFznJDVsUvmu5JkrG16XupOLxIrT3xRxMKJ8=", "https://media.istockphoto.com/photos/plums-fresh-plums-picture-id1257344030?k=20&m=1257344030&s=612x612&w=0&h=5bzcEVyMttyc-EkEZebmu-JFOakMQoqiOTOmxVDln2s=", true, false, "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.You can dice, slice or cut it in rings and put it in burgers and sandwiches.Onions emit a sharp flavour and fragrance once they are fried; it is due to the sulphur compound in the vegetable.Onions are known to be rich in biotin. Most of the flavonoids which are known as anti - oxidants are concentrated more in the outer layers, so when you peel off the layers, you should remove as little as possible. Onions are known to have antiseptic, antimicrobial and antibiotic properties which help you to get rid of infections. If a piece of onion is inhaled, it can slow down or stop nose bleeding. Those who have sleeping disorders or insomnia can have a good night sleep if they have an onion every day. Onions also help to improve the functions of the digestive system; because it releases the digestive juices and cures any problem related to digestion. Onions, like garlic, are also rich in sulphur compounds. Onions are known to contain manganese, copper, Vitamin B6, Vitamin C, Folic acid, Amino acid and dietary fibers along with phosphorus, folate and copper.", "Kiwi (3 units)", 66m, "Onion is a round vegetable with a brown skin that grows underground." },
                    { 2, "Unbranded", 1, "", "", true, false, "", "Plum (250 g)", 78m, "Plums can be as large as a baseball or a small as a cherry when ripe, all grown from the same tree." },
                    { 3, "Unbranded", 1, "", "", true, false, "", "Pineapple, 1 Unit (600gm - 1 kg)", 49m, "" },
                    { 4, "Unbranded", 1, "", "", true, false, "", "Sweet Lime / Mosambi, 3 Units  (450 g - 650 g)", 58m, "" },
                    { 5, "Unbranded", 1, "", "", true, false, "", "Orange Navel Imported, 3 Units  (450 g - 600 g)", 87m, "" },
                    { 6, "Unbranded", 1, "", "", true, false, "", "Apple Red Delicious, 2 Units  (250 - 330 g)", 127m, "" },
                    { 7, "Unbranded", 1, "", "", true, false, "", "Sapota Chikoo (250 g)", 34m, "" },
                    { 8, "Unbranded", 1, "", "", true, false, "", "Pear Green (2 Units)", 69m, "" },
                    { 9, "Unbranded", 1, "", "", true, false, "", "Pomegranate 2 Units  (420 - 500 g)", 108m, "" },
                    { 10, "Unbranded", 1, "", "", true, false, "", "Banana Robusta (500 g)", 62m, "" },
                    { 11, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70", true, false, "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.You can dice, slice or cut it in rings and put it in burgers and sandwiches.Onions emit a sharp flavour and fragrance once they are fried; it is due to the sulphur compound in the vegetable.Onions are known to be rich in biotin. Most of the flavonoids which are known as anti - oxidants are concentrated more in the outer layers, so when you peel off the layers, you should remove as little as possible. Onions are known to have antiseptic, antimicrobial and antibiotic properties which help you to get rid of infections. If a piece of onion is inhaled, it can slow down or stop nose bleeding. Those who have sleeping disorders or insomnia can have a good night sleep if they have an onion every day. Onions also help to improve the functions of the digestive system; because it releases the digestive juices and cures any problem related to digestion. Onions, like garlic, are also rich in sulphur compounds. Onions are known to contain manganese, copper, Vitamin B6, Vitamin C, Folic acid, Amino acid and dietary fibers along with phosphorus, folate and copper.", "Fresh Onion (1 kg)", 26m, "Onion is a round vegetable with a brown skin that grows underground." },
                    { 12, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70", true, false, "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling. These freshly picked potatoes are a great choice for roasting or boiling. They give essential nutrients to your body along with high dietary fibre and carbohydrates. Combined with great taste and nutrients this vegetable is the most popular and loved amongst households. It is a very good diet for those who have mouth ulcers.It is easy to digest and facilitate digestion making them a good diet for patients.Potatoes are easy to digest and facilitate digestion making them a good diet for patients, babies and those who cannot digest hard food but need energy.They maintain good blood glucose level which does not let brain fatigue creep in and keeps the brain active and alert.It is good for the heart and beneficial for people having kidney stones.Apart from containing useful minerals such as potassium, iron, copper and magnesium, potatoes are also full of phytochemical antioxidants such as flavonoids, Vitamin B and folate.Fresho New potatoes are either Round or Oblong which is about 45mm-65 mm in diameter. Consume them within a few days of purchase. ", "Fresh Potato (1 kg)", 37m, "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!" },
                    { 13, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70", "", true, false, "", "Cabbage, 1 Units  (500 – 800gm)", 26m, "" },
                    { 14, "Organic", 2, "", "", true, false, "", "Tomato (1 kg)", 30m, "" },
                    { 15, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70", "", true, false, "Carrots are a great addition to soups and stews, appetizers and hors d'oeuvres, side dishes and salads. They can be roasted in the oven or boiled on the stove top. Try using carrots in place of potato slices in soup, for a lower-carbohydrate meal. They can also be used in place of pasta, in casseroles, and even shredded and added to homemade breads when substituting them for grains is called for. So, go ahead, buy Carrot Orange 500 g online now!", "Carrot (500 g)", 71m, "" },
                    { 16, "Organic", 2, "", "", true, false, "", "Brinjal (250 g)", 33m, "" },
                    { 17, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70", "", true, false, "", "Mint Leaves (100 g)", 19m, "" },
                    { 18, "Organic", 2, "", "", true, false, "", "Amaranthus Red (250 g)", 24m, "" },
                    { 19, "Organic", 2, "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70", "", true, false, "", "Beans Haricot (250 g)", 22m, "" },
                    { 20, "Organic", 2, "", "", true, false, "", "Bhindi/Okra (250 g)", 17m, "" },
                    { 21, "India Gate", 3, "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70", true, false, " Having this rice is truly having a feast rozzana (a daily feast); combine it with your veggies and serve a nice pulao. Without this Basmati Rice, your biryanis will seem dull and tasteless. This is the perfect ingredient for different rice recipes. Energy--344kcal, Protein--6.7g, Carbohydrate--77g, Fat--0.5gg, Dietary Fibre--1.4g, Potassium--105mg, Magnesium--65mg, Phosphorus--120mg, Thiamine--0.45mg, Riboflavin--0.05mg, Niacin--4.1mg", "Feast Rozzana Basmati Rice", 85m, "India Gate Feast Rozzana Basmati Rice  is defined by its long grains and amazing aromatic flavour." },
                    { 22, "Aashirvaad", 3, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", true, false, "Made from the King of Wheat – Sharbati, Aashirvaad Select is a premium quality aata which is made with love in India. This sharbati wheat flour contains 100% Sharbati wheat from select regions of Madhya Pradesh. The grains of sharabati atta are consistent in size and have a golden sheen to it. Aashirvaad experts handpick the grains ensuring that the grains are consistent in size and have the golden glow that makes Aashirvaad Select Atta truly Select. The fields of Sharbati wheat in the regions of Madhya Pradesh are sun-kissed to perfection and showered by the right amount of rain. The dough made from the King of Wheat – Sharbati, absorbs more water which leads to the rotis being sweet in taste and softer in texture. Behind every atta pack is the Aashirvaad experts who’ve made it with extra care. By using Aashirvaad’s process to lock in the nutrients in the flour, it ensures that you and your family receive all the nutrients. Aashirvaad Select makes sure that you and your family remain fit and healthy as you enjoy delicious, soft, and fluffy rotis. Aashirvaad Select is made with 100% Sharbati wheat which is harvested from selected regions of Madhya Pradesh. Aashirvaad Select is a premium quality atta made from the King of Wheat – Sharbati wheat grains which are consistent in size and have a golden sheen. Rotis made with Aashirvaad Select Sharbati atta are sweet in taste and softer in texture. This premium quality wheat flour has been made with Aashirvaad’s process to lock in nutrition which ensures that you and your family receive the taste as well as nutrition. Aashirvaad Select has been made with love in India", "Aashirvaad Select Sharbatti Atta", 85m, "Aashirvaad Select is a premium quality atta made from the King of Wheat – Sharbati wheat grains" },
                    { 23, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70", "", true, false, "", "Aashirvaad Nature's Superfoods Multi Millet Mix  (500 g)", 57m, "" },
                    { 24, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70", "", true, false, "", "Aashirvaad Natures Superfoods Ragi Flour  (1 kg)", 90m, "" },
                    { 25, "Aashirvaad", 3, "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70", "", true, false, "", "Aashirvaad Sugar Release Control Atta  (1 kg)", 80m, "" },
                    { 26, "WeiKFiELD", 3, "", "", true, false, "", "WeiKFiELD Cornflour  (100 g)", 30m, "" },
                    { 27, "Fortune", 3, "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70", "", true, false, "", "Fortune Besan  (500 g)", 55m, "" },
                    { 28, "Safe Harvest", 3, "", "", true, false, "", "Safe Harvest Roasted Sooji  (500 g)", 50m, "" },
                    { 29, "", 3, "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70", "", true, false, "", "", 8m, "" },
                    { 30, "", 3, "", "", true, false, "", "", 9m, "" },
                    { 111, "Britannia", 3, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", true, false, "A treasure for the lovers of choco packed between the surplus of crunch and sprinkled with delicate sugar crystals. Smooth, melted chocolate fills your mouth with a sweet delighted taste for a mouth-watering experience. Enjoy these chocolicious biscuits with your fun gang to add sweetness in the moments. Britannia Bourbon is made for the people who can’t get enough of chocolate. Trust of Britannia and pure ingredients have made these biscuits everyone’s favourite.", "Bourbon Chocolate Cream Biscuits (50 g)", 10m, "Britannia Bourbon is made for the people who can’t get enough of chocolate." },
                    { 112, "Haldirams", 3, "https://i.pinimg.com/736x/8b/64/45/8b6445a600bd18e708ee3c7d5ddb0353.jpg", "https://cdn.shopify.com/s/files/1/0501/5361/9606/products/1_3980ed7e-002d-4b35-828b-77586be12f11_512x720.jpg?v=1657172703", true, false, "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks. This are delicious and flavourful snacks. It is crispy, flavourful and textured. This delightful snack can be eaten as it is. Its a healthy alternative for potato chips. Haldiram's was founded in 1941 by Ganga Bishan Agarwal, fondly known as Haldiram Ji in his household; as a retail sweets and namkeen shop in Bikaner, Rajasthan. In order to drive expansion, the company's first manufacturing plant was started in Calcutta (now Kolkata).", "Aloo Bhujia Namkeen (150 g)", 33m, "Haldirams Aloo Bhujia is a authentic namkeen." },
                    { 113, "Coca-Cola ", 4, "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", true, false, "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks. This are delicious and flavourful snacks. It is crispy, flavourful and textured. This delightful snack can be eaten as it is. Its a healthy alternative for potato chips. Haldiram's was founded in 1941 by Ganga Bishan Agarwal, fondly known as Haldiram Ji in his household; as a retail sweets and namkeen shop in Bikaner, Rajasthan. In order to drive expansion, the company's first manufacturing plant was started in Calcutta (now Kolkata).", "Coca-Cola Soft Drink Can", 31m, "Haldirams Aloo Bhujia is a authentic namkeen." },
                    { 114, "Sprite", 4, "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg", "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70", true, false, "Let the lemon-flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly. This refreshing beverage complements meals, and also, it gives you instant energy to sail through the hot summer days. Clean and Crisp Flavour. This lemon - flavour drink has a clean and crisp taste. Ideal Summer Drink. This is a refreshing summer drink that hydrates your senses. Drink Anytime. You can drink Sprite with your meals, on the move, and also while chilling with friends. Perfect Party Drink. This drink is perfect for parties and gatherings. Serve Chilled. To quench your thirst, drink it chilled and bubbling.", "Sprite Can", 35m, "Let the lemon - flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
