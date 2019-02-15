using System;

namespace Examples.ViewModels
{
    public enum CardType
    {
        Danger,
        Warning,
        Info
    }

    public class CardViewModel
    {
        public CardType Type { get; set; } = CardType.Info;
        public string Message { get; set; } = "";

        public string TypeName => Enum.GetName(typeof(CardType), Type).ToLower();
    }
}
