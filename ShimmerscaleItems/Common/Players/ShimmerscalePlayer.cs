using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using WillFish.Content.Items;
using WillFish.Content.Items.Accessories;
using static Terraria.ID.ContentSamples.CreativeHelper;
using rail;
using System.Collections.Generic;
using Terraria.IO;

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
