using Yossef_Hawila.Enums;
using Yossef_Hawila.Models;

namespace Yossef_Hawila.Interface
{
    public interface IMultiLanguage
    {
        public Dictionary<Languages, PortfolioModel> PortfolioModels { get; }
        public Dictionary<Languages, LanguageSettingsModel> SettingsModels { get; }


    }
}
