using TheColorsMod_C21341.Sae.Buff;

namespace TheColorsMod_C21341.Sae.Card
{
    public class DiceCardSelfAbility_RagingDeath_C21341 : DiceCardSelfAbilityBase
    {
        public override void OnEndBattle()
        {
            if (card.target != null && card.target.IsDead())
                owner.bufListDetail.AddBuf(new BattleUnitBuf_RagingDeath_C21341());
        }
    }
}