using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CompletionMod
{
	public class CompletionModPlayer : ModPlayer
	{
		public CompletionModPlayer Instance;

		private static readonly int spawnSpaceX = 3;
		private static readonly int spawnSpaceY = 3;

		private static readonly int spawnRangeX = (int)((double)(NPC.sWidth / 16) * 0.7);
		private static readonly int spawnRangeY = (int)((double)(NPC.sHeight / 16) * 0.7);

		public static void SpawnCompletionWOF(Vector2 pos)
		{
			if (pos.Y / 16f < (float)(Main.maxTilesY - 205) || Main.netMode == NetmodeID.MultiplayerClient)
				return;
			Player.FindClosest(pos, 16, 16);
			int num14 = 1;
			if (pos.X / 16f > (float)(Main.maxTilesX / 2))
				num14 = -1;
			bool flag = false;
			int num13 = (int)pos.X;
			while (!flag)
			{
				flag = true;
				for (int i = 0; i < 255; i++)
					if (Main.player[i].active && Main.player[i].position.X > (float)(num13 - 1200) && Main.player[i].position.X < (float)(num13 + 1200))
					{
						num13 -= num14 * 16;
						flag = false;
					}
				if (num13 / 16 < 20 || num13 / 16 > Main.maxTilesX - 20)
					flag = true;
			}
			int num12 = (int)pos.Y;
			int num11 = num13 / 16;
			int num10 = num12 / 16;
			int num9 = 0;
			while (true)
			{
				try
				{
					if (!WorldGen.SolidTile(num11, num10 - num9) && Main.tile[num11, num10 - num9].liquid < 100)
						num10 -= num9;
					else
						if (WorldGen.SolidTile(num11, num10 + num9) || Main.tile[num11, num10 + num9].liquid >= 100)
						{
							num9++;
							continue;
						}
						num10 += num9;
				}
				catch
				{
				}
				break;
			}
			if (num10 < Main.maxTilesY - 180)
				num10 = Main.maxTilesY - 180;
			num12 = num10 * 16;
			int num7 = NPC.NewNPC(num13, num12, 113);
			if (Main.netMode == NetmodeID.SinglePlayer)
				Main.NewText(Language.GetTextValue("Announcement.HasAwoken", Main.npc[num7].TypeName), 175, 75);
			else if (Main.netMode == NetmodeID.Server)
				NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasAwoken", Main.npc[num7].GetTypeNetName()), new Color(175, 75, 255));
		}
		public static void SpawnOnCompletionPlayer(int plr, int Type)
		{
			{
				if (Main.netMode == NetmodeID.MultiplayerClient)
					return;
				/*if (Type == 262 && NPC.AnyNPCs(262)) //Plantera. Probably so it doesn't get summoned again when you break a bulb?
					return;*/
				/*if (Type == 245) //Golem. *shrug*
				{
					if (NPC.AnyNPCs(245))
						return;
					try
					{
						int num = (int)Main.player[plr].Center.X / 16;
						int num2 = (int)Main.player[plr].Center.Y / 16;
						int num3 = 0;
						int num4 = 0;
						for (int i = num - 20; i < num + 20; i++)
							for (int j = num2 - 20; j < num2 + 20; j++)
								if (Main.tile[i, j].active() && Main.tile[i, j].type == 237 && Main.tile[i, j].frameX == 18 && Main.tile[i, j].frameY == 0)
								{
									num3 = i;
									num4 = j;
								}
						if (num3 > 0 && num4 > 0)
						{
							int num5 = num4 - 15;
							int num6 = num4 - 15;
							for (int k = num4; k > num4 - 100; k--)
								if (WorldGen.SolidTile(num3, k))
								{
									num5 = k;
									break;
								}
							for (int l = num4; l < num4 + 100; l++)
								if (WorldGen.SolidTile(num3, l))
								{
									num6 = l;
									break;
								}
							num4 = (num5 + num5 + num6) / 3;
							int num7 = NPC.NewNPC(num3 * 16 + 8, num4 * 16, 245, 100, 0f, 0f, 0f, 0f, 255);
							Main.npc[num7].target = plr;
							string typeName = Main.npc[num7].TypeName;
							if (Main.netMode == 0)
								Main.NewText(Language.GetTextValue("Announcement.HasAwoken", typeName), 175, 75, 255, false);
							else if (Main.netMode == 2)
								NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasAwoken", new object[]
										{
										Main.npc[num7].GetTypeNetName()
										}), new Color(175, 75, 255), -1);
						}
					}
					catch { }
					return;
				}*/
				/*else if (Type == 370) //Duke Fishron
				{
					Player player = Main.player[plr];
					if (!player.active || player.dead)
						return;
					int m = 0;
					while (m < 1000)
					{
						Projectile projectile = Main.projectile[m];
						if (projectile.active && projectile.bobber && projectile.owner == plr)
						{
							int num8 = NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y + 100, 370, 0, 0f, 0f, 0f, 0f, 255);
							string typeName2 = Main.npc[num8].TypeName;
							if (Main.netMode == NetmodeID.SinglePlayer)
							{
								Main.NewText(Language.GetTextValue("Announcement.HasAwoken", typeName2), 175, 75, 255, false);
								return;
							}
							if (Main.netMode == NetmodeID.Server)
							{
								NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasAwoken", new object[]
										{
										Main.npc[num8].GetTypeNetName()
										}), new Color(175, 75, 255), -1);
								return;
							}
							break;
						}
						else
						{
							m++;
						}
					}
					return;
				}*/
				else
				{
					if (Type != 398) //Moon Lord's core.
					{
						bool flag = false;
						int num9 = 0;
						int num10 = 0;
						int num11 = (int)(Main.player[plr].position.X / 16f) - spawnRangeX * 2;
						int num12 = (int)(Main.player[plr].position.X / 16f) + spawnRangeX * 2;
						int num13 = (int)(Main.player[plr].position.Y / 16f) - spawnRangeY * 2;
						int num14 = (int)(Main.player[plr].position.Y / 16f) + spawnRangeY * 2;
						int num15 = (int)(Main.player[plr].position.X / 16f) - NPC.safeRangeX;
						int num16 = (int)(Main.player[plr].position.X / 16f) + NPC.safeRangeX;
						int num17 = (int)(Main.player[plr].position.Y / 16f) - NPC.safeRangeY;
						int num18 = (int)(Main.player[plr].position.Y / 16f) + NPC.safeRangeY;
						if (num11 < 0)
							num11 = 0;
						if (num12 > Main.maxTilesX)
							num12 = Main.maxTilesX;
						if (num13 < 0)
							num13 = 0;
						if (num14 > Main.maxTilesY)
							num14 = Main.maxTilesY;
						for (int n = 0; n < 1000; n++)
						{
							int num19 = 0;
							while (num19 < 100)
							{
								int num20 = Main.rand.Next(num11, num12);
								int num21 = Main.rand.Next(num13, num14);
								if (Main.tile[num20, num21].nactive() && Main.tileSolid[(int)Main.tile[num20, num21].type])
									goto IL_7F7;
								if ((!Main.wallHouse[(int)Main.tile[num20, num21].wall] || n >= 999) && (Type != 50 || n >= 500 || Main.tile[num21, num21].wall <= 0))
								{
									int num22 = num21;
									while (num22 < Main.maxTilesY)
									{
										if (Main.tile[num20, num22].nactive() && Main.tileSolid[(int)Main.tile[num20, num22].type])
										{
											if (num20 < num15 || num20 > num16 || num22 < num17 || num22 > num18 || n == 999)
											{
												num9 = num20;
												num10 = num22;
												flag = true;
												break;
											}
											break;
										}
										else
											num22++;
									}
									if (flag && Type == 50 && n < 900)
									{
										int num23 = 20;
										if (!Collision.CanHit(new Vector2((float)num9, (float)(num10 - 1)) * 16f, 16, 16, new Vector2((float)num9, (float)(num10 - 1 - num23)) * 16f, 16, 16) || !Collision.CanHit(new Vector2((float)num9, (float)(num10 - 1 - num23)) * 16f, 16, 16, Main.player[plr].Center, 0, 0))
										{
											num9 = 0;
											num10 = 0;
											flag = false;
										}
									}
									if (!flag || n >= 999)
										goto IL_7F7;
									int num24 = num9 - spawnSpaceX / 2;
									int num25 = num9 + spawnSpaceX / 2;
									int num26 = num10 - spawnSpaceY;
									int num27 = num10;
									if (num24 < 0)
										flag = false;
									if (num25 > Main.maxTilesX)
										flag = false;
									if (num26 < 0)
										flag = false;
									if (num27 > Main.maxTilesY)
										flag = false;
									if (flag)
										for (int num28 = num24; num28 < num25; num28++)
											for (int num29 = num26; num29 < num27; num29++)
												if (Main.tile[num28, num29].nactive() && Main.tileSolid[(int)Main.tile[num28, num29].type])
												{
													flag = false;
													break;
												}
										goto IL_7F7;
								}
							IL_7FF:
								num19++;
								continue;
							IL_7F7:
								if (!flag && !flag)
									goto IL_7FF;
								break;
							}
							if (flag && n < 999)
							{
								Rectangle rectangle = new Rectangle(num9 * 16, num10 * 16, 16, 16);
								for (int num30 = 0; num30 < 255; num30++)
									if (Main.player[num30].active)
									{
										Rectangle rectangle2 = new Rectangle((int)(Main.player[num30].position.X + (float)(Main.player[num30].width / 2) - (float)(NPC.sWidth / 2) - (float)NPC.safeRangeX), (int)(Main.player[num30].position.Y + (float)(Main.player[num30].height / 2) - (float)(NPC.sHeight / 2) - (float)NPC.safeRangeY), NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
										if (rectangle.Intersects(rectangle2))
											flag = false;
									}
							}
							if (flag)
								break;
						}
						if (flag)
						{
							int num31 = NPC.NewNPC(num9 * 16 + 8, num10 * 16, Type, 1, 0f, 0f, 0f, 0f, 255);
							if (num31 == 200)
							{
								return;
							}
							Main.npc[num31].target = plr;
							Main.npc[num31].timeLeft *= 20;
							string typeName3 = Main.npc[num31].TypeName;
							if (Main.netMode == NetmodeID.Server && num31 < 200)
								NetMessage.SendData(MessageID.SyncNPC, -1, -1, null, num31, 0f, 0f, 0f, 0, 0, 0);
							if (Type == 134 || Type == 127 || Type == 126 || Type == 125)
								AchievementsHelper.CheckMechaMayhem(-1);
							if (Type == 125)
							{
								if (Main.netMode == NetmodeID.SinglePlayer)
								{
#pragma warning disable CS0618 // Type or member is obsolete
									Main.NewText(Lang.misc[48].Value, 175, 75, 255, false);
#pragma warning restore CS0618 // Type or member is obsolete
									return;
								}
								if (Main.netMode == NetmodeID.Server)
								{
#pragma warning disable CS0618 // Type or member is obsolete
									NetMessage.BroadcastChatMessage(Lang.misc[48].ToNetworkText(), new Color(175, 75, 255), -1);
#pragma warning restore CS0618 // Type or member is obsolete
									return;
								}
							}
							else if (Type != 82 && Type != 126 && Type != 50 && Type != 398 && Type != 551)
							{
								if (Main.netMode == NetmodeID.SinglePlayer)
								{
									Main.NewText(Language.GetTextValue("Announcement.HasAwoken", typeName3), 175, 75, 255, false);
									return;
								}
								if (Main.netMode == NetmodeID.Server)
								{
									NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasAwoken", new object[]
											{
											Main.npc[num31].GetTypeNetName()
											}), new Color(175, 75, 255), -1);
								}
							}
						}
						return;
					}
					if (NPC.AnyNPCs(Type)) //Huzzah! Screw this!
					{
						//return;
					}
					Player player2 = Main.player[plr];
					NPC.NewNPC((int)player2.Center.X, (int)player2.Center.Y - 150, Type, 0, 0f, 0f, 0f, 0f, 255);
					if (Main.netMode == NetmodeID.SinglePlayer)
					{
						Main.NewText(Language.GetTextValue("Announcement.HasAwoken", Language.GetTextValue("Enemies.MoonLord")), 175, 75, 255, false);
						return;
					}
					if (Main.netMode == NetmodeID.Server)
					{
						NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasAwoken", new object[]
								{
								NetworkText.FromKey("Enemies.MoonLord", new object[0])
								}), new Color(175, 75, 255), -1);
					}
					return;
				}
			}
		}
	}
}