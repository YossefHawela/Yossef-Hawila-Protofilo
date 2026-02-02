using Yossef_Hawila.Constants;
using Yossef_Hawila.Enums;
using Yossef_Hawila.Interface;

namespace Yossef_Hawila.Models
{

    public class PageLanguageBagModel : IMultiLanguage,IMultiLanguageBag<PortfolioModel>
    {
        public Languages Language { get;set; } = Languages.En;

        Dictionary<Languages, PortfolioModel> IMultiLanguageBag<PortfolioModel>.Model { get; set; } = new ()
        {
            {Languages.Ar , AvailableLanguages.ArabicPortfolioModel},
            {Languages.En , AvailableLanguages.EnglishPortfolioModel }
        };

        public Dictionary<Languages, PortfolioModel> PortfolioModels => ((IMultiLanguageBag<PortfolioModel>)this).Model;


    }
}

