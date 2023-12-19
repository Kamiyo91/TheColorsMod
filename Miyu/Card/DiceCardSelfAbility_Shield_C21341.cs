namespace TheColorsMod_C21341.Miyu.Card
{
    public class DiceCardSelfAbility_Shield_C21341 : DiceCardSelfAbility_MiyuCommonCard_C21341
    {
        public override string[] Keywords
        {
            get
            {
                return new[]
                {
                    "Healer_C21341",
                    "MagicShield_C21341"
                };
            }
        }

        public override void OnUseCard()
        {
            owner.allyCardDetail.DrawCards(1);
        }
    }
}