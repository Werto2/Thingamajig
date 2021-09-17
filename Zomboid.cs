using IL.Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;
using System;

namespace aWeeMod.NPCs
{
	public class Zomboid : ModNPC
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Zombiod"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			npc.npcSlots = 1;
			npc.width = 32;
			npc.height = 44;
			npc.aiStyle = 3;
			npc.damage = 10;
			npc.defense = 3;
			npc.lifeMax = 35;
			npc.stepSpeed = 5;
			npc.frame = new Rectangle(0, 0, 34, 46);

			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;

			npc.knockBackResist = 0.4f;
			npc.value = 60;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;

		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return 10;
		}
	}
}