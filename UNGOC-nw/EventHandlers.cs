using CustomPlayerEffects;
using InventorySystem;
using MEC;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using System.Collections.Generic;

namespace UNGOC_NW
{
    internal class EventHandlers
    {
        public static List<Player> UNGOC_C = new List<Player>();
        [PluginEvent(PluginAPI.Enums.ServerEventType.RoundStart)]
        public void OnRoundStart()
        {
            Respawning.WaveManager.OnWaveSpawned += OnTeamRespawning;
            if (Plugin.Config.Debug)
                Log.Debug("Round Start!");
            SpawnTimes = 0;
            UNGOC_C.Clear();
        }
        public ushort SpawnTimes = 0;
        public IEnumerator<float> RespawnTeam(List<Player> Players)
        {
            if (Plugin.Config.Debug)
                Log.Debug(" 刷新UNGOC! / Respawn UNGOC!");
            if (Plugin.Config.EnableBroadcast)
                Map.Broadcast(7, Plugin.Config.Broadcast);
            if (Plugin.Config.EnableAnnouncement)
            {
                Cassie.Clear();
                SteveAPI.Cassie.MessageTranslated(Plugin.Config.Announcement, Plugin.Config.Announcement_Translation);
            }
            yield return Timing.WaitForSeconds(0.5f);
            foreach (Player player in Players)
            {
                if (UNGOC_C.Count < 1)
                {
                    UNGOC_TeamRespawn.PlayerSpawn_GOCC(player);
                }
                if (!UNGOC_C.Contains(player))
                {
                    UNGOC_TeamRespawn.PlayerSpawn_GOCP(player);
                }
            }
            UNGOC_C.Clear();
        }

        private void OnTeamRespawning(Respawning.Waves.SpawnableWaveBase arg1, List<ReferenceHub> arg2)
        {
            if (Plugin.Config.Debug)
                Log.Debug("Respawn Team!");
            if (arg1.TargetFaction != PlayerRoles.Faction.FoundationStaff)
                return;
            SpawnTimes++;
            if (SpawnTimes == Plugin.Config.SpawnTimes)
            {
                var PlayerList = new List<Player>();
                foreach(ReferenceHub hub in arg2)
                {
                    PlayerList.Add(Player.Get(hub));
                }
                Timing.RunCoroutine(RespawnTeam(PlayerList));
            }
        }

        private class UNGOC_TeamRespawn 
        {
            public static void PlayerSpawn_GOCP(Player player)
            {
                player.SetRole(Plugin.Config.UNGOCPrivate_Role);
                player.ClearInventory();
                foreach (ItemType item in Plugin.Config.RespawnItems_Private)
                {
                    player.ReferenceHub.inventory.ServerAddItem(item, InventorySystem.Items.ItemAddReason.AdminCommand);
                }
                player.AddAmmo(Plugin.Config.RespawnAmmo_Private, Plugin.Config.RespawnAmmos_Private);
                player.SendBroadcast(Plugin.Config.UNGOCPrivate_Info,5);
            }
            public static void PlayerSpawn_GOCC(Player player)
            {
                UNGOC_C.Add(player);
                player.SetRole(Plugin.Config.UNGOCCaptain_Role);
                player.ClearInventory();
                if(Plugin.Config.UNGOCCaptain_SCP1853Effect)
                    player.EffectsManager.EnableEffect<Scp1853>();
                foreach(ItemType item in Plugin.Config.RespawnItems_Captain)
                {
                    player.ReferenceHub.inventory.ServerAddItem(item,InventorySystem.Items.ItemAddReason.AdminCommand);
                }
                player.AddAmmo(Plugin.Config.RespawnAmmo_Captain, Plugin.Config.RespawnAmmos_Captain);
                player.SendBroadcast(Plugin.Config.UNGOCCaptain_Info, 5);
            }
        }
    }
}
