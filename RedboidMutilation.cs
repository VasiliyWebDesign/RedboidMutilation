using Terraria.ModLoader;
using Terraria.ID;


namespace RedboidMutilation
{
	public class RedboidMutilation : Mod
	{
		public override void AddRecipes()
		{
			//Adds a recipe for super absorbant sponge
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddIngredient(ItemID.Coral, 10);
			recipe.AddIngredient(ItemID.SandBlock, 30);
			recipe.anySand = true;
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.SuperAbsorbantSponge);
			recipe.AddRecipe();


			//Adds a recipe for hotline fishing hook
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HellstoneBar, 14);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.HotlineFishingHook);
			recipe.AddRecipe();

			//Adds a recipe for piranha gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.JungleKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PiranhaGun);
			recipe.AddRecipe();

			//Adds a recipe for scourge of the corruptor
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CorruptionKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ScourgeoftheCorruptor);
			recipe.AddRecipe();

			//Adds a recipe for vampire knives
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CrimsonKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.VampireKnives);
			recipe.AddRecipe();

			//Adds a recipe for rainbow gun
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.HallowedKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RainbowGun);
			recipe.AddRecipe();

			//Adds a recipe for staff of the frost hydra
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.FrozenKey);
			recipe.AddIngredient(ItemID.Ectoplasm, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.StaffoftheFrostHydra);
			recipe.AddRecipe();

			//Adds a recipe for magic mirror
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.Glass, 20);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();

			//Adds a recipe for lock box (gold)
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.GoldBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for lock box (platinum)
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddIngredient(ItemID.PlatinumBar, 25);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(ItemID.LockBox);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteMask);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 8);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 6);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();

			//Adds a recipe for chlorophyte refund
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.ChlorophyteBar, 4);
			recipe.AddRecipe();
		}
	}
}