namespace basics.Models
{
    //Burada datalara ulaşmak için ortak bir alan oluşturuluyor. Repository üzerinden controller içerisindeki fonksiyonlara
    //data çekilebiliyor.
    public class Repository
    {
        //burada müdahale edilemeyen bir _courses objesi oluşturuluyor.
        private static readonly List<Course> _courses = new List<Course>();

        // construct methodu içerisinde eklenmiş olan veriler gönderiliyor.
        static Repository()
        {
            _courses = new List<Course>()
            {
                    new Course() {
                        Id = 1,
                        Title = "Aspnet Kursu",
                        Description = "Aspnet Kurs Açıklaması",
                        Image="2.jpeg",
                        isActive = true,
                        isHome = true,
                        Tags = new string[]{"aspnet","web geliştirme"}
                        },
                    new Course() {
                        Id = 2,
                        Title = "Laravel Kursu",
                        Description = "Laravel Kurs Açıklaması",
                        Image = "3.png",
                        isActive = true,
                        isHome = true,
                        Tags = new string[]{"laravel","web geliştirme"}
                        },
                    new Course() {
                        Id = 3,
                        Title = "Python Kursu",
                        Description = "Python Kurs Açıklaması",
                        Image = "1.jpeg",
                        isActive = true,
                        isHome = false,
                        }
            };
        }
        // Courses fonksiyonu üzerinden _courses objesine ulaşılıyor ve data geri döndürülüyor.
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        // GetById fonksiyonu Course tipinde olan ilk eşleşen datayı lambda expression alarak eşleştiriyor. Course yanında yer alan ? dönecek
        // olan değeri null gelebileceğini söylüyor. Aynı zamanda id parametremiz de null gelecek olursa ona göre aksiyon alabilmeliyiz.
        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}