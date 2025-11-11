using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ShimmerscaleItems.Common.Players
{

    public class ShimmerscalePlayer : ModPlayer
    {
        public bool hasBigGem;
        public bool hasGamBlade;
        private int grantCoins;

        Random random = new Random();

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            base.OnHitNPC(target, hit, damageDone);
            if (hasGamBlade)
            {
                grantCoins = random.Next(0, 200);
                if (grantCoins == 0)
                {
                    Player.QuickSpawnItem(null, ItemID.Emerald, 1);
                }
                else if (grantCoins > 0 && grantCoins < 101)
                {
                    Player.QuickSpawnItem(null, ItemID.Ruby, 1);
                }

            }
        }

        public override void ResetEffects()
        {
            hasBigGem = false;
            hasGamBlade = false;
        }
    }
}
