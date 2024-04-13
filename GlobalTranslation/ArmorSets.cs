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
                player.setBonus = "测试";
               }
            if (set == "WitchenHatSet") 
            {
                player.setBonus = "测试";
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
