using TheConfectionRebirth.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Mounts
{
	public class Rollercycle : ModMountData
	{
		public override void SetDefaults() {
			mountData.buff = ModContent.BuffType<RollercycleBuff>();
			mountData.heightBoost = 0;
			mountData.fallDamage = 0f;
			mountData.runSpeed = 11f;
			mountData.dashSpeed = 8f;
			mountData.flightTimeMax = 0;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 20;
			mountData.acceleration = 0.19f;
			mountData.jumpSpeed = 10f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 4;
			mountData.constantJump = false;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++) {
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 13;
			mountData.bodyFrame = 3;
			mountData.yOffset = -24;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 4;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 0;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 0;
			mountData.inAirFrameDelay = 0;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 1;
			mountData.idleFrameDelay = 10;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = false;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode == NetmodeID.Server) {
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width + 20;
			mountData.textureHeight = mountData.backTexture.Height;
		}
		
		public override void UpdateEffects(Player player) {
		  if (!(Math.Abs(player.velocity.X) > 4f)) {
				return;
			}
			Rectangle rect = player.getRect();
		}
		internal class CcretSpecificData
		{
			internal int count;
			internal float[] rotations;
			internal static float[] offsets = new float[] { 0, 14, -14 };
			public CcretSpecificData() {
				count = 3;
				rotations = new float[count];
			}
		}
	}
}