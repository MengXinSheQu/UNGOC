using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using Respawning;
using System.Collections.Generic;
using UNGOC.SteveAPI;

namespace UNGOC
{
    internal class EventHandlers
    {
        internal static List<Player> UNGOC_C = new List<Player>(); 
        public static void RegEvent() 
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStart;
            Exiled.Events.Handlers.Server.RespawningTeam += OnRespawningTeam;
        }
        public static void UnRegEvent()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStart;
            Exiled.Events.Handlers.Server.RespawningTeam -= OnRespawningTeam;
        }
        private static void OnRoundStart() 
        {
            Dummy.Destory();
            SpawnTimes = 0;
            UNGOC_C.Clear();
        }
        private static ushort SpawnTimes = 0;
        private static void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam != SpawnableTeamType.NineTailedFox)
                return;
            SpawnTimes++;
            if(SpawnTimes == Plugin.UNGOCPlugin.Config.SpawnTimes) 
            {
                if (Plugin.UNGOCPlugin.Config.Debug)
                    Log.Debug(" 刷新UNGOC! / Respawn UNGOC!");
                if (Plugin.UNGOCPlugin.Config.EnableBroadcast)
                    Map.Broadcast(7, Plugin.UNGOCPlugin.Translation.Broadcast);
                if (Plugin.UNGOCPlugin.Config.EnableMusic)
                    Dummy.PlaySound(Plugin.UNGOCPlugin.Config.MusicPath);
                if (Plugin.UNGOCPlugin.Config.EnableAnnouncement)
                    Cassie.MessageTranslated(Plugin.UNGOCPlugin.Translation.Announcement, Plugin.UNGOCPlugin.Translation.Announcement_Translation);
                foreach (Player player in ev.Players) 
                { 
                    if(UNGOC_C.Count < 1)
                    {
                        UNGOC_TeamRespawn.PlayerSpawn_GOCC(player);
                    }
                    if(!UNGOC_C.Contains(player))
                    {
                        UNGOC_TeamRespawn.PlayerSpawn_GOCP(player);
                    }
                }
                UNGOC_C.Clear();
                ev.IsAllowed = false;
                ev.NextKnownTeam = SpawnableTeamType.None;
            }
        }
        public class UNGOC_TeamRespawn 
        {
            public static void PlayerSpawn_GOCP(Player player)
            {
                player.Role.Set(Plugin.UNGOCPlugin.Config.UNGOCPrivate_Role);
                player.ClearInventory();
                foreach (ItemType item in Plugin.UNGOCPlugin.Config.RespawnItems_Private)
                {
                    player.AddItem(item);
                }
                player.Broadcast(5, Plugin.UNGOCPlugin.Translation.UNGOCPrivate_Info);
            }
            public static void PlayerSpawn_GOCC(Player player)
            {
                UNGOC_C.Add(player);
                player.Role.Set(Plugin.UNGOCPlugin.Config.UNGOCCaptain_Role);
                player.ClearInventory();
                if(Plugin.UNGOCPlugin.Config.UNGOCCaptain_SCP1853Effect)
                    player.EnableEffect<Scp1853>();
                foreach(ItemType item in Plugin.UNGOCPlugin.Config.RespawnItems_Captain)
                {
                    player.AddItem(item);
                }
                player.Broadcast(5, Plugin.UNGOCPlugin.Translation.UNGOCCaptain_Info);
            }
        }
    }
}
