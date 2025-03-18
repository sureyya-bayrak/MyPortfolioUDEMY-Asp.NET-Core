using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        //Bu class DbContext class'ından miras alır.
        //DbContext EntityFrameworkCore kütüphanesinden gelir.
        //DbContext sınıfı veritabanı işlemlerini yapmamızı sağlar.
        //Veritabanı işlemleri: Ekleme, Silme, Güncelleme, Listeleme işlemi yapmamızı sağlar.
        //DbContext sınıfı içerisinde DbSet'leri barındırır.
        //DbSet'ler veritabanındaki tablolara karşılık gelir.
        //Örneğin; Veritabanında bir SocialMedia tablosu varsa, bu tabloya karşılık gelen bir DbSet oluşturulur.
        //Bu DbSet SocialMedia tablosu ile haberleşmemizi sağlar.
        //Bu DbSet üzerinden SocialMedia tablosuna veri ekleyebilir, silebilir, güncelleyebilir ve listeleme işlemi yapabiliriz.
        //Bu DbSet üzerinden SocialMedia tablosundaki verileri çekebiliriz. 
        //Bu durum tüm tablolar için geçerlidir.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bu metot DbContext sınıfının bir metotudur.
            //Bu metot içerisinde veritabanı bağlantı bilgileri tanımlanır


            optionsBuilder.UseSqlServer("Server=DESKTOP-I83KKRS;initial catalog=MyPortfolioDB;integrated security=true;TrustServerCertificate=true");
            //Buraya TrustServerCertificate=true eklememizin sebebi, sertifikasız bir şekilde veritabanına bağlanabilmek istememizdi.
            //"Sertifika zinciri güvenilir olmayan bir yetkili tarafından verildi" hatası almıştık ve bu hatayı çözmek için TrustServerSertificate=true ekledik.
        }
        //UseSqlServer metodu ile veritabanı bağlantı bilgileri tanımlanır.
        //Server=DESKTOP-I83KKRS; -> Veritabanı sunucusunun adı
        //initial catalog=MyPortfolioDB; -> Veritabanının adı
        //integrated security=true -> Windows Authentication ile veritabanına bağlanılacağını belirtir.
        //integrated security=true -> Bağlantımın güvenli olduğu bilgisini söylemiş oldum.

        //Clean Code prensiplerini araştır.Clean Code prensiplerine uygun kod yazmaya çalış.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }

        //ORM nedir?
        //ORM(Object Relational Mapping) bir programlama tekniğidir.
        //ORM ile veritabanı işlemleri yapılırken, veritabanı tabloları ile nesneler arasında bir ilişki kurulur.
        //ORM ile veritabanı tabloları nesnelere dönüştürülür.

        //EntityFramework ve Dapper ORM aracıdır.
        //Daha ayrıntılı bilgiyi araştır.

        //Controller back-end kodlarımızı yazdığımız alandır.

    } }


        
    




    

