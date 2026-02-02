using Yossef_Hawila.Models;

namespace Yossef_Hawila.Constants
{
    public static class AvailableLanguages
    {
        public static readonly PortfolioModel EnglishPortfolioModel = new()
        {
            Summary = """
            Software engineer with solid experience in backend development using C# and .NET Core.
            Skilled in database integration, system design, and building efficient, maintainable web applications(backend).
            """,
            Location = "Desouk, Kafr El Sheikh, Egypt"
        };

        public static readonly PortfolioModel ArabicPortfolioModel = new()
        {
            Summary = """
            مهندس برمجيات خبير في التعامل مع برمجه المواقع باستخدام لغه ال سي شارب و دوت نيت كور
            قادر علي التعامل مع مختلف انواع قواعد البيانات من تصميم و بناء هيكل بيانات للموقع الاكتروني
            """,
            Location = "دسوق, كفرالشيخ, مصر"
        };
    }
}
