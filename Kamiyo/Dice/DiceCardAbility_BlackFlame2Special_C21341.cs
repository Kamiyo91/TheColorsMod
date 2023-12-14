using LOR_DiceSystem;
using TheColorsMod_C21341.Kamiyo.Buff;
using TheColorsMod_C21341.Kamiyo.Card;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Kamiyo.Dice
{
    public class DiceCardAbility_BlackFlame2Special_C21341 : DiceCardAbilityBase
    {
        public override string[] Keywords => new[] { "BlackFlame_C21341" };

        public override void OnSucceedAttack()
        {
            if (!(card.cardAbility is DiceCardSelfAbility_BlackFlameSlash_C21341 ability) || !ability.Active ||
                behavior.Type == BehaviourType.Standby) return;
            card.target?.OnAddBuff<BattleUnitBuf_BlackFlame_C21341>(2);
        }
    }
}