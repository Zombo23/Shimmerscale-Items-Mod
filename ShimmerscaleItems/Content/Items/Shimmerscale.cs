using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShimmerscaleItems.Content.Items
{ 
	public class Shimmerscale : ModItem
	{
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.maxStack = 999;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Yellow;
        }

        public override void SetStaticDefaults() 
        {
            ItemID.Sets.CanBePlacedOnWeaponRacks[Type] = true;
        }
    }
}
