using Terraria;
using Terraria.ModLoader;

namespace LunarVeilzhcn.GlobalTranslation
{
    public class ArmorSets : GlobalItem
    {
        #region UpdateArmorSet
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == "套装英文名Set") 
            {
                player.setBonus = "文本";
               }
            if (set == "套装英文名Set") 
            {
                player.setBonus = "文本";
               }
        }
        #endregion
        #region IsArmorSet
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            ModItem item = ModContent.GetInstance<套装头盔的英文名>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "Set";
            }
            item = ModContent.GetInstance<套装头盔的英文名>();
            if (item.Type == head.type && item.IsArmorSet(head, body, legs))
            {
                return "Set";
            }
            return base.IsArmorSet(head, body, legs);
        }
        #endregion
    }
}
