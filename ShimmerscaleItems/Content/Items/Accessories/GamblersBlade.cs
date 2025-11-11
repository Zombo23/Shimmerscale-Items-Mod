using Microsoft.Build.Utilities;
using S.Content.Items;
using ShimmerscaleItems.Common.Players;
using ShimmerscaleItems.Content.Items;
using System;
using Terraria;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace WillFish.Content.Items.Accessories
{ 
	public class GamblersBlade : ModItem
	{
		public static readonly int attackSpeedBonus = 12;
		public int meleeSpeedBonus = 0;
		public override void SetDefaults()
		{
			Item.width = 38;
			Item.height = 38;
			Item.value = Item.buyPrice(gold: 1);
			Item.accessory = true;
			Item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.GetModPlayer<ShimmerscalePlayer>().hasGamBlade = true;
			player.GetAttackSpeed(DamageClass.Generic) += attackSpeedBonus / 100f;
            meleeSpeedBonus =+ Main.LocalPlayer.FindItem(ItemID.GoldCoin);
            if (meleeSpeedBonus > 30)
            {
				meleeSpeedBonus = 30;
            }
			if	(Main.LocalPlayer.FindItem(ItemID.PlatinumCoin) > 0)
            {
				meleeSpeedBonus = 30;
            }
			player.GetAttackSpeed(DamageClass.Melee) += meleeSpeedBonus / 100f;
		}

        public override void AddRecipes()
		{
			CreateRecipe()
                .AddIngredient(ModContent.ItemType<Shimmerscale>())
			    .AddIngredient(ItemID.FeralClaws)
			    .AddTile(TileID.WorkBenches)
			    .Register();
		}
	}
}
