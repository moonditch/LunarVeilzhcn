using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ModLoader;

namespace LunarVeilzhcn.GlobalTranslation
{
	public class ItemTooltips : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			foreach (TooltipLine tooltipLine in tooltips)
			{
			//Hiker's Backpack
			tooltipLine.Text = tooltipLine.Text.Replace("Hiker's Backpack", "Hiker的旅行背包");
			tooltipLine.Text = tooltipLine.Text.Replace("Increased Regeneration!", "增加回复速度！");
			tooltipLine.Text = tooltipLine.Text.Replace("+3% damage", "增加3%的伤害");
			tooltipLine.Text = tooltipLine.Text.Replace("Drops stumps on the ground as you walk!", "行走时在地面上掉落尖刺！");
			}
		}
	}
}