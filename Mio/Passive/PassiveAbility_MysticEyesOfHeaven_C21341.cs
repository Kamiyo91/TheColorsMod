using System.Collections.Generic;
using System.Linq;
using LOR_DiceSystem;
using TheColorsMod_C21341.Mio.Buff;
using UtilLoader21341;
using UtilLoader21341.Enum;
using UtilLoader21341.Util;

namespace TheColorsMod_C21341.Mio.Passive
{
    public class PassiveAbility_MysticEyesOfHeaven_C21341 : PassiveAbilityBase
    {
        private BattleUnitBuf_MysticEyesOfHeaven_C21341 _buff;
        private List<AtkTypeMin> _cachedResistType = new List<AtkTypeMin>();
        private bool _changed;
        private BattleUnitModel _target;
        public bool Activated;

        public override void BeforeGiveDamage(BattleDiceBehavior behavior)
        {
            if (!Activated) return;
            if (behavior?.card == null || !behavior.card.CheckTargetSpeedByCard(1)) return;
            _changed = true;
            _target = behavior.card.target;
            if (_target == null) return;
            var getAttackTypes = new List<AtkResistType>();
            var setAttackTypes = new List<AtkResistType>();
            if (_target.GetResistHP(behavior.Detail) > _buff.AtkType)
            {
                getAttackTypes.Add(new AtkResistType(behavior.Detail, CustomDamageType.HP,
                    _target.GetResistHP(behavior.Detail)));
                setAttackTypes.Add(new AtkResistType(behavior.Detail, CustomDamageType.HP, _buff.AtkType));
            }

            if (_target.GetResistBP(behavior.Detail) > _buff.AtkType)
            {
                getAttackTypes.Add(new AtkResistType(behavior.Detail, CustomDamageType.BP,
                    _target.GetResistBP(behavior.Detail)));
                setAttackTypes.Add(new AtkResistType(behavior.Detail, CustomDamageType.BP, _buff.AtkType));
            }

            foreach (var item in getAttackTypes)
                _cachedResistType.Add(new AtkTypeMin
                {
                    AtkResist = item.AtkResist, BehaviourDetail = item.BehaviourDetail,
                    IsHpResist = item.DamageType == CustomDamageType.HP
                });
            if (setAttackTypes.Any())
                _target.SetAttackTypes(setAttackTypes);
        }

        public override void OnWaveStart()
        {
            if (!UnitUtil.CheckOriginalPage(new LorId(TheColorsModParameters.PackageId, 10000001),
                    owner.Book.GetBookClassInfoId())) Active();
        }

        public void Active()
        {
            Activated = true;
            name = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("MysticEyesPassive_C21341")).Value.Name;
            desc = ModParameters.LocalizedItems[TheColorsModParameters.PackageId].EffectTexts
                .FirstOrDefault(x => x.Key.Equals("MysticEyesPassive_C21341")).Value.Desc;
            _buff =
                owner.OnAddBuff<BattleUnitBuf_MysticEyesOfHeaven_C21341>(1) as BattleUnitBuf_MysticEyesOfHeaven_C21341;
        }

        public override void AfterGiveDamage(int damage)
        {
            if (!_changed) return;
            _changed = false;
            _buff.AtkType = AtkResist.Normal;
            if (_target == null) return;
            if (_cachedResistType.Any())
            {
                var normalAtkResistList = _cachedResistType.Select(item => new AtkResistType(item.BehaviourDetail,
                    item.IsHpResist ? CustomDamageType.HP : CustomDamageType.BP, item.AtkResist)).ToList();
                _target.SetAttackTypes(normalAtkResistList);
                _cachedResistType = new List<AtkTypeMin>();
            }

            _target = null;
        }

        public override void OnRoundStart()
        {
            if (!Activated) return;
            _buff =
                owner.OnAddBuff<BattleUnitBuf_MysticEyesOfHeaven_C21341>(0) as BattleUnitBuf_MysticEyesOfHeaven_C21341;
        }

        public class AtkTypeMin
        {
            public AtkResist AtkResist { get; set; }
            public BehaviourDetail BehaviourDetail { get; set; }
            public bool IsHpResist { get; set; }
        }
    }
}