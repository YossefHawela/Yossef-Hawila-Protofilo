using Yossef_Hawila.Models;

namespace Yossef_Hawila.Constants
{
    //Can be replaced with database/xml or any simple file system in reallife examples
    public static class AvailableLanguages
    {

        public static readonly PortfolioModel EnglishPortfolioModel = new()
        {
            Name = "Yossef Hawila",
            Phone ="01070522020",
            Email = "yossefhawila37@gmail.com",
            GitHub = "https://github.com/YossefHawela",
            LinkedIn = "https://www.linkedin.com/in/yossef-hawila-a4475033b/",
            Summary = """
            Software engineer with solid experience in backend development using C# and .NET Core.
            Skilled in database integration, system design, and building efficient, maintainable web applications(backend).
            """,
            Location = "Desouk, Kafr El Sheikh, Egypt"
        };

        public static readonly PortfolioModel ArabicPortfolioModel = new()
        {
            Name = "يوسف حويله",
            Phone = "01070522020",
            Email = "yossefhawila37@gmail.com",
            GitHub = "https://github.com/YossefHawela",
            LinkedIn = "https://www.linkedin.com/in/yossef-hawila-a4475033b/",
            Summary = """
            مهندس برمجيات خبير في التعامل مع برمجه المواقع باستخدام لغه ال سي شارب و دوت نيت كور
            قادر علي التعامل مع مختلف انواع قواعد البيانات من تصميم و بناء هيكل بيانات للموقع الاكتروني
            """,
            Location = "دسوق, كفرالشيخ, مصر"
        };

        public static LanguageSettingsModel EnglishSettingsModel = new()
        {
            Direction = Enums.Directions.ltr
        };
        public static LanguageSettingsModel ArabicSettingsModel = new()
        {
            Direction = Enums.Directions.rtl
        };
    }
}
