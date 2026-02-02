using Yossef_Hawila.Enums;

namespace Yossef_Hawila.Interface
{
    public interface IMultiLanguageBag<T>
    {
        public Dictionary<Languages, T> Model { get; set; }
    }
}
