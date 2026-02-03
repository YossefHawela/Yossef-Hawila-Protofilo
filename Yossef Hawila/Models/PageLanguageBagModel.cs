using Yossef_Hawila.Constants;
using Yossef_Hawila.Enums;
using Yossef_Hawila.Interface;

namespace Yossef_Hawila.Models
{

    public class PageLanguageBagModel : IMultiLanguage,IMultiLanguageBag<PortfolioModel>,IMultiLanguageBag<LanguageSettingsModel>
    {
        Dictionary<Languages, PortfolioModel> IMultiLanguageBag<PortfolioModel>.Model { get; set; } = new ()
        {
            {Languages.Ar , AvailableLanguages.ArabicPortfolioModel},
            {Languages.En , AvailableLanguages.EnglishPortfolioModel }
        };

        Dictionary<Languages, LanguageSettingsModel> IMultiLanguageBag<LanguageSettingsModel>.Model { get; set; } = new()
        {
            {Languages.Ar , AvailableLanguages.ArabicSettingsModel},
            {Languages.En , AvailableLanguages.EnglishSettingsModel }
        };


        public Dictionary<Languages, PortfolioModel> PortfolioModels { get => ((IMultiLanguageBag<PortfolioModel>)this).Model; }
        public Dictionary<Languages, LanguageSettingsModel> SettingsModels { get => ((IMultiLanguageBag<LanguageSettingsModel>)this).Model; }


    }
}