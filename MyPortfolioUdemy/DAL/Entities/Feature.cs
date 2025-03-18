namespace MyPortfolioUdemy.DAL.Entities
{
    public class Feature
    {
        /*Portfolyoda öne çıkan alan için Feature sınıfını 
        Entities adlı klasör içinde oluşturduk. */
        public int FeatureId { get; set; }
        /*Id property'sinin birincil anahtar olduğunu gösterebilmemiz
        için adlandırmada bulunduğu sınıf ismini başına ekledik*/

        public  string Title { get; set; }  
        public string Description { get; set; }

        
    }
}
