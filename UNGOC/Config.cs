using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace UNGOC
{
    public class Config : IConfig
    {
        [Description("启动UNGOC插件 / Enable UNGOC Plugin")]
        public bool IsEnabled { get; set; } = true;

        [Description("启动Debug / Enable Debug")]
        public bool Debug { get; set; } = false;

        [Description("如果刷新九尾狐，第几次将刷新UNGOC(如果为0则跳过) / If Respawn Ntf , What times will spawn UNGOC? (If 0 , Skip)")]
        public ushort SpawnTimes { get; set; } = 1;

        [Description("如果刷新UNGOC，启动广播/If Respawn UNGOC , Enable Announcement")]
        public bool EnableAnnouncement { get; set; } = true;
        [Description("如果刷新UNGOC，启动全图播报Broadcase? /If Respawn UNGOC , Enable Map Broadcast")]
        public bool EnableBroadcast { get; set; } = true;
        [Description("UNGOC列兵物品 / UNGOC Private Personnel Item List")]
        public List<ItemType> RespawnItems_Private { get; set; } = new List<ItemType>()
        {
            ItemType.GunE11SR,
            ItemType.ArmorCombat,
            ItemType.Adrenaline,
            ItemType.Medkit,
            ItemType.KeycardMTFOperative,
            ItemType.Radio
        };
        [Description("UNGOC指挥官物品 / UNGOC Captain Item List")]
        public List<ItemType> RespawnItems_Captain { get; set; } = new List<ItemType>() 
        {
            ItemType.GunFRMG0,
            ItemType.ArmorHeavy,
            ItemType.Adrenaline,
            ItemType.Medkit,
            ItemType.GrenadeHE,
            ItemType.KeycardMTFCaptain,
            ItemType.Radio
        };
        [Description("UNGOC列兵弹药类型 / UNGOC Private Personnel Ammo Type")]
        public AmmoType RespawnAmmo_Private { get; set; } = AmmoType.Nato556;
        [Description("UNGOC列兵弹药数量 / UNGOC Private Personnel Ammos")]
        public ushort RespawnAmmos_Private { get; set; } = 60;
        [Description("UNGOC指挥官弹药类型 / UNGOC Captain Personnel Ammo Type")]
        public AmmoType RespawnAmmo_Captain { get; set; } = AmmoType.Nato556;
        [Description("UNGOC指挥官弹药数量 / UNGOC Private Personnel Ammos")]
        public ushort RespawnAmmos_Captain { get; set; } = 100;
        [Description("UNGOC指挥官启用SCP1853效果 / Enable UNGOC Captain SCP1853 Effect")]
        public bool UNGOCCaptain_SCP1853Effect { get; set; } = true;
        [Description("UNGOC指挥官角色类型 / UNGOC Captain Role")]
        public RoleTypeId UNGOCCaptain_Role { get; set; } = RoleTypeId.NtfCaptain;
        [Description("UNGOC列兵角色类型 / UNGOC Private Role")]
        public RoleTypeId UNGOCPrivate_Role { get; set; } = RoleTypeId.NtfSpecialist;
        [Description("启动UNGOC刷新音乐 / Enable UNGOC Respawn Music")]
        public bool EnableMusic { get; set; } = true;
        [Description("UNGOC刷新音乐路径 / UNGOC Respawn Music Path")]
        public string MusicPath { get; set; } = Paths.Exiled + "\\UNGOC.ogg";
    }
}
