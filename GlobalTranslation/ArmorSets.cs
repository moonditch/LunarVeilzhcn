using Terraria;
using Terraria.ModLoader;
using Stellamod.Items.Armors.Windmillion;
using Stellamod.Items.Armors.Witchen;

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

            ModItem item = ModContent.GetInstance<AlsisMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "AlsisMaskSet";
            }

            ModItem item = ModContent.GetInstance<ArtisanMask>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "ArtisanMaskSet";
            }

            item = ModContent.GetInstance<WitchenHat>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "WitchenHatSet";
            }
            return base.IsArmorSet(head, body, legs);
        }
        #endregion
    }
}
