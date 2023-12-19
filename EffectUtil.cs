using System;
using System.Linq;
using LOR_DiceSystem;
using Sound;
using UnityEngine;

namespace TheColorsMod_C21341
{
    public static class EffectUtil
    {
        public static void BurnEffect(BattleUnitModel owner)
        {
            var gameObject = Util.LoadPrefab("Battle/DiceAttackEffects/New/FX/DamageDebuff/FX_DamageDebuff_Fire");
            if (gameObject != null && owner?.view != null)
            {
                var pss = gameObject.GetComponentsInChildren<ParticleSystem>();
                var count = 0;
                foreach (var ps in pss)
                {
                    if (count != 2 && count != 0) ps.gameObject.SetActive(false);
                    var main = ps.main;
                    main.startColor = new Color(0, 0, 0, 1);
                    count++;
                }

                gameObject.transform.parent = owner.view.camRotationFollower;
                gameObject.transform.localPosition = Vector3.zero;
                gameObject.transform.localScale = Vector3.one;
                gameObject.transform.localRotation = Quaternion.identity;
            }

            SoundEffectPlayer.PlaySound("Buf/Effect_Burn");
        }

        public static void MakeEffect(BattleUnitModel unit, string path, float sizeFactor = 1f,
            BattleUnitModel target = null, float destroyTime = -1f)
        {
            try
            {
                SingletonBehavior<DiceEffectManager>.Instance.CreateCreatureEffect(path, sizeFactor, unit.view,
                    target?.view, destroyTime);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void PrepareDeckMiyu(BattleUnitModel owner, bool notChangeDie)
        {
            foreach (var card in owner.allyCardDetail.GetAllDeck()
                         .Where(x => !TheColorsModParameters.MiyuDeck.Contains(x.GetID())))
            {
                card.CopySelf();
                var copiedSpec = card.XmlData.Spec.Copy();
                copiedSpec.Ranged = CardRange.Far;
                card.XmlData.Spec = copiedSpec;
                if (notChangeDie) continue;
                foreach (var dice in card.GetBehaviourList())
                    ChangeCardDiceEffectMiyu(dice);
            }
        }

        public static void ChangeCardDiceEffectMiyu(DiceBehaviour dice)
        {
            var tryGetValue = TheColorsModParameters.MiyuEffects.TryGetValue(dice.MotionDetail, out var effect);
            if (tryGetValue) dice.EffectRes = effect;
        }
    }
}