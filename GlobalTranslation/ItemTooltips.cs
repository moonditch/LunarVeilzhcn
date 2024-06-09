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
			//紫色文字
			tooltipLine.Text = tooltipLine.Text.Replace("Simple Brooch!", "简单的胸针!");
			}
		}
	}
}