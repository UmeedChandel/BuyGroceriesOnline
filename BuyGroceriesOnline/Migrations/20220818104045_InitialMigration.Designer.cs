﻿// <auto-generated />
using System;
using BuyGroceriesOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuyGroceriesOnline.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220818104045_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BuyGroceriesOnline.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruits",
                            Description = "Fruits are a rich source of vitamins, minerals, fibres and proteins. "
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Vegetables",
                            Description = "Vegetables contain many vitamins and minerals that are good for your health."
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Cereals",
                            Description = "We should eat fresh fruits to keep ourselves healthy. "
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Snacks Store",
                            Description = "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid."
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Beverages",
                            Description = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. "
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Cleaning & Household",
                            Description = "We should eat fresh fruits to keep ourselves healthy. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. "
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Beauty & Makeup",
                            Description = "These include vitamins A (beta-carotene), C and E, magnesium, zinc, phosphorous and folic acid."
                        });
                });

            modelBuilder.Entity("BuyGroceriesOnline.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FeedBack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("FeedbackId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("BuyGroceriesOnline.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "Unbranded",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://media.istockphoto.com/photos/red-cherry-plum-with-green-leaves-isolated-on-white-background-picture-id687478414?k=20&m=687478414&s=612x612&w=0&h=eI2g4RbgFznJDVsUvmu5JkrG16XupOLxIrT3xRxMKJ8=",
                            ImageUrl = "https://media.istockphoto.com/photos/plums-fresh-plums-picture-id1257344030?k=20&m=1257344030&s=612x612&w=0&h=5bzcEVyMttyc-EkEZebmu-JFOakMQoqiOTOmxVDln2s=",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.",
                            Name = "Kiwi (3 units)",
                            Price = 66m,
                            ShortDescription = "Onion is a round vegetable with a brown skin that grows underground."
                        },
                        new
                        {
                            ProductId = 11,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/k/y/d/5-onion-un-branded-no-whole-original-imafdsyg4ykqcyt4.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Onion is a vegetable which is almost like a staple in Indian food. This is also known to be one of the essential ingredients of raw salads. They come in different colours like white, red or yellow and are quite in demand in cold salads and hot soups.",
                            Name = "Fresh Onion (1 kg)",
                            Price = 26m,
                            ShortDescription = "Onion is a round vegetable with a brown skin that grows underground."
                        },
                        new
                        {
                            ProductId = 12,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/jtsz3bk0/vegetable/b/8/4/2-potato-un-branded-no-whole-original-imafdsymh2aepaph.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.  ",
                            Name = "Fresh Potato (1 kg)",
                            Price = 37m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 13,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/km9ht3k0/vegetable/y/o/3/cabbage-unbranded-whole-no-original-imagf7fpazpgzcwm.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "These are a special variant early harvest of potatoes and are easily distinguishable with their thin/ tender skin which makes them easy-to-peel off even it can be used without peeling.",
                            Name = "Cabbage, 1 Units  (500 – 800gm)",
                            Price = 26m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 15,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kuczmvk0/vegetable/h/s/j/carrot-ooty-un-branded-no-whole-original-imag7hvnqty9v5gu.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Carrots are a great addition to soups and stews, appetizers and hors d'oeuvres, side dishes and salads. They can be roasted in the oven or boiled on the stove top. Try using carrots in place of potato slices in soup, for a lower-carbohydrate meal.",
                            Name = "Carrot (500 g)",
                            Price = 71m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 17,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ked56kw0/vegetable/8/h/z/100-mint-leaves-un-branded-no-whole-original-imafv2ftybhf2erb.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                            Name = "Mint Leaves (100 g)",
                            Price = 19m,
                            ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. "
                        },
                        new
                        {
                            ProductId = 19,
                            Brand = "Organic",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kc3p30w0/vegetable/t/m/x/250-beans-haricot-un-branded-whole-no-original-imaftauycjuhr4ay.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                            Name = "Beans Haricot (250 g)",
                            Price = 22m,
                            ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. "
                        },
                        new
                        {
                            ProductId = 21,
                            Brand = "India Gate",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/knqd3m80/rice/9/o/d/white-feast-rozzana-na-basmati-rice-pouch-india-gate-original-imag2c7wfzxrfwdy.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = " Having this rice is truly having a feast rozzana (a daily feast); combine it with your veggies and serve a nice pulao. Without this Basmati Rice, your biryanis will seem dull and tasteless. ",
                            Name = "Feast Rozzana Basmati Rice",
                            Price = 85m,
                            ShortDescription = "India Gate Feast Rozzana Basmati Rice  is defined by its long grains and amazing aromatic flavour."
                        },
                        new
                        {
                            ProductId = 22,
                            Brand = "Aashirvaad",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                            ImageUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Made from the King of Wheat – Sharbati, Aashirvaad Select is a premium quality aata which is made with love in India. This sharbati wheat flour contains 100% Sharbati wheat from select regions of Madhya Pradesh. ",
                            Name = "Aashirvaad Select Sharbatti Atta",
                            Price = 85m,
                            ShortDescription = "Aashirvaad Select is a premium quality atta made from the King of Wheat – Sharbati wheat grains"
                        },
                        new
                        {
                            ProductId = 23,
                            Brand = "Aashirvaad",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l4hcx3k0/flour/0/l/1/-original-imagfd3gtdjrsxds.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "",
                            Name = "Aashirvaad Nature's Superfoods Multi Millet Mix  (500 g)",
                            Price = 57m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 24,
                            Brand = "Aashirvaad",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l26hdow0/flour/4/k/s/-original-imagdkghzc9yhdtv.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "",
                            Name = "Aashirvaad Natures Superfoods Ragi Flour  (1 kg)",
                            Price = 90m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 25,
                            Brand = "Aashirvaad",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ki96c280/flour/f/7/z/1-sugar-release-control-atta-1-whole-wheat-flour-aashirvaad-original-imafy2w5hjxwhrjy.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "",
                            Name = "Aashirvaad Sugar Release Control Atta  (1 kg)",
                            Price = 80m,
                            ShortDescription = "If you are looking for soft, slightly sweet but creamy-textured potatoes. You're at right place!"
                        },
                        new
                        {
                            ProductId = 27,
                            Brand = "Fortune",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/kqidx8w0/flour/a/r/d/besan-besan-fortune-original-imag4gb46e9zwps8.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. ",
                            Name = "Fortune Besan  (500 g)",
                            Price = 55m,
                            ShortDescription = "But we should not eat cut fruits at the market as they are very unhygienic and can make us ill. "
                        },
                        new
                        {
                            ProductId = 29,
                            Brand = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/ktx9si80/flour/c/t/e/roasted-sooji-soji-safe-harvest-original-imag762nfygx9sdc.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Britannia Bourbon is made for the people who can’t get enough of chocolate, Britannia Bourbon is made for the people who can’t get enough of chocolate",
                            Name = "Oiginal",
                            Price = 8m,
                            ShortDescription = "Britannia Bourbon is made for the people who can’t get enough of chocolate"
                        },
                        new
                        {
                            ProductId = 111,
                            Brand = "Britannia",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                            ImageUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "A treasure for the lovers of choco packed between the surplus of crunch and sprinkled with delicate sugar crystals. Smooth, melted chocolate fills your mouth with a sweet delighted taste for a mouth-watering experience. Enjoy these chocolicious biscuits with your fun gang to add sweetness in the moments. Britannia Bourbon is made for the people who can’t get enough of chocolate. Trust of Britannia and pure ingredients have made these biscuits everyone’s favourite.",
                            Name = "Bourbon Chocolate Cream Biscuits (50 g)",
                            Price = 10m,
                            ShortDescription = "Britannia Bourbon is made for the people who can’t get enough of chocolate."
                        },
                        new
                        {
                            ProductId = 112,
                            Brand = "Haldirams",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://i.pinimg.com/736x/8b/64/45/8b6445a600bd18e708ee3c7d5ddb0353.jpg",
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0501/5361/9606/products/1_3980ed7e-002d-4b35-828b-77586be12f11_512x720.jpg?v=1657172703",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.",
                            Name = "Aloo Bhujia Namkeen (150 g)",
                            Price = 33m,
                            ShortDescription = "Haldirams Aloo Bhujia is a authentic namkeen."
                        },
                        new
                        {
                            ProductId = 113,
                            Brand = "Coca-Cola ",
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "This classic snack is made with chickpea flour, potato and some spices. This is a popular Indian snack that is originated from Rajasthan. It is a great accompaniment to savoury snacks that adds texture to classic Indian snacks.",
                            Name = "Coca-Cola Soft Drink Can",
                            Price = 31m,
                            ShortDescription = "Haldirams Aloo Bhujia is a authentic namkeen."
                        },
                        new
                        {
                            ProductId = 114,
                            Brand = "Sprite",
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://m.media-amazon.com/images/I/81l7thl5AQL._SL1500_.jpg",
                            ImageUrl = "https://rukminim1.flixcart.com/image/832/832/l3dcl8w0/aerated-drink/w/b/2/-original-imagegf8yccvrgvx.jpeg?q=70",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            LongDescription = "Let the lemon-flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly. This refreshing beverage complements meals, and also, it gives you instant energy to sail through the hot summer days. Clean and Crisp Flavour",
                            Name = "Sprite Can",
                            Price = 35m,
                            ShortDescription = "Let the lemon - flavour of the Sprite soft drink quench your thirst and refresh your taste buds instantly."
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BuyGroceriesOnline.Models.Product", b =>
                {
                    b.HasOne("BuyGroceriesOnline.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuyGroceriesOnline.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
