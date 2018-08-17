/* I though I'd give the supporters a little treat by sharing a little bit of code for this upcoming mod.
 * Here is one of the weapons's main code and the coders out there can figure out what type of weapon i'm doing.
 * I'll do more of these once I get comfortable enough to share the code with you guys.
 * Up until then, enjoy this code!
*/

using Terraria.ModLoader;
using Terraria.Graphics.Shaders;
using Terraria.UI;

namespace riotModdingTutorial.Items.Weapons
{
    public class ??? : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("???");
            Tooltip.SetDefault("The power of this sigil gives you a strange feeling");
        }
        public override void SetDefaults()
        {
            item.damage = ???;
            item.width = 32;
            item.height = 32;
            item.scale = 0.2f;
            item.useTime = ???;
            item.useAnimation = ???;
            item.useStyle = 1;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 10, 50, 40);
            item.rare = 11;
            item.UseSound = SoundID.Item39;
            item.shoot = mod.ProjectileType("???");
            item.autoReuse = true;
            item.shootSpeed = ???;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(???, 25);
            ???
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(9);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .8f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

}
