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
			//银色星辰文字
			tooltipLine.Text = tooltipLine.Text.Replace("Can be changed to", "可以变成");
			//绿色文字
			tooltipLine.Text = tooltipLine.Text.Replace("(A) Great Damage scaling for explosions!", "(A) 爆炸造成的巨大伤害 !");
			//红色文字
			tooltipLine.Text = tooltipLine.Text.Replace("(Special) The farther your cursor is, the faster the axe goes!", "(特殊) 光标越远，斧头砍得越快");
			//黄色文字
			tooltipLine.Text = tooltipLine.Text.Replace("(A) Very High Damage Scaling with knives!", "(A) Very High Damage Scaling with knives!（仅测试可无翻译，来自穹月汉化硬翻代码源，以后测试加更新）");
			tooltipLine.Text = tooltipLine.Text.Replace("(A) Very High Damage Scaling with frost explosions!", "(A) Very High Damage Scaling with frost explosions!（仅测试可无翻译，来自穹月汉化硬翻代码源，以后测试加更新）");
			}
		}
	}
}