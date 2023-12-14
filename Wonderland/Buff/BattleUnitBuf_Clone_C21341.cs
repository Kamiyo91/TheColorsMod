namespace TheColorsMod_C21341.Wonderland.Buff
{
    public class BattleUnitBuf_Clone_C21341 : BattleUnitBuf
    {
        public override bool IsControllable => _owner.faction == Faction.Enemy;

        public override int GetCardCostAdder(BattleDiceCardModel card)
        {
            return -99;
        }
    }
}