using ShimmerscaleItems.Common.Players;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Build.Utilities;

namespace ShimmerscaleItems.Content.Items.Accessories
{ 
	public class NeedlesslyBigGem : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 26;
			Item.height = 32;
			Item.value = Item.buyPrice(gold: 1);
			Item.accessory = true;
			Item.rare = ItemRarityID.Yellow;
		}
		
        public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<ShimmerscalePlayer>().hasBigGem = true;
        }

        public override void AddRecipes()
		{
			CreateRecipe()
			    .AddIngredient(ModContent.ItemType<Shimmerscale>())
			    .AddIngredient(ItemID.Ruby)
			    .AddTile(TileID.WorkBenches)
			    .Register();
		}
	}
}
