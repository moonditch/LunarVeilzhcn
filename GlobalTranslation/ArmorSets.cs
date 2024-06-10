using Terraria;
using Terraria.ModLoader;
using Stellamod.Items.Armors.Windmillion;
using Stellamod.Items.Armors.Witchen;
using Stellamod.Items.Armors.Artisan;
using Stellamod.Items.Armors.Alsis;
using Stellamod.Items.Armors.Govheil;
using Stellamod.Items.Armors.Xexterian;

namespace LunarVeilzhcn.GlobalTranslation
{
    public class ArmorSets : GlobalItem
    {
        #region UpdateArmorSet
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "WindmillionHatSet") 
            {
                player.setBonus = "我是万里挑一的\n增加30%的投掷攻速！\n大幅增加投掷击退";
               }

            if (set == "AlsisMaskSet") 
            {
                player.setBonus = "你是一个真正的法师........\n获得魔力花和魔法手铐的效果并扩大魔力的拾取范围\n增加25%魔法伤害！\n魔力消耗降低70%并超级的增加魔力值回复";
               }

            if (set == "ArtisanMaskSet") 
            {
                player.setBonus = "3.2.1微笑！就像你站在舞台上好吗:P\n每隔一段时间会获得一段倒计时，倒计时结束后暴击率100%则攻击翻倍\n走路会留下油漆\n暴击率和盔甲穿透增加20！";
               }

            if (set == "WitchenHatSet") 
            {
                player.setBonus = "真是一个敢于奉献的人! 女巫们都非常尊敬你 :P\n获得魔力花和魔法手铐的效果\n极限的增加魔力值回复\n魔力消耗降低50%\n华丽的节奏";
               }
            //忍钢套装效果
          if (set == "GovheilMaskSet") 
            {
                player.setBonus = "敌人可能不会太瞄准你\n忍钢之刃会保护你\n每隔一段时间，魔法和召唤伤害都会增加一次\n最大召唤栏增加2";
               }
 /*           if (set == "GovheilHelmetSet") 作者文案错误占位符
            {
                player.setBonus = "？\n？\n？\n？";
               }*/

          if (set == "XexterianHatSet") 
            {
                player.setBonus = "拥有沙漠靴的功能\n没有沙漠靴也能快速奔跑\n增加5点防御\n拥有禁戒盔甲的套装效果\n将木箭转化为烈焰箭";
               }
        }
        #endregion
        #region IsArmorSet
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            ModItem item = ModContent.GetInstance<WindmillionHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WindmillionHatSet";
            }

            item = ModContent.GetInstance<AlsisMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AlsisMaskSet";
            }

            item = ModContent.GetInstance<ArtisanMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ArtisanMaskSet";
            }

            item = ModContent.GetInstance<WitchenHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WitchenHatSet";
            }

            item = ModContent.GetInstance<GovheilMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "GovheilMask";
            }
 /*            item = ModContent.GetInstance<GovheilHelmet>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "GovheilHelmet";
            }*/

            item = ModContent.GetInstance<XexterianHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "XexterianHat";
            }
            return base.IsArmorSet(head, body, legs);
        }
        #endregion
    }
}
