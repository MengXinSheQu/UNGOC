using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace UNGOC_NW
{
    public class Config
    {
        [Description("启动Debug / Enable Debug")]
        public bool Debug { get; set; } = false;
        [Description("如果刷新九尾狐，第几次将刷新UNGOC(如果为0则跳过) / If Respawn Ntf , What times will spawn UNGOC? (If 0 , Skip)")]
        public ushort SpawnTimes { get; set; } = 1;

        [Description("如果刷新UNGOC，启动广播/If Respawn UNGOC , Enable Announcement")]
        public bool EnableAnnouncement { get; set; } = true;
        [Description("如果刷新UNGOC，启动全图播报Broadcase? /If Respawn UNGOC , Enable Map Broadcast")]
        public bool EnableBroadcast { get; set; } = true;
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
        [Description("UNGOC列兵弹药类型 / UNGOC Private Personnel Ammo Type")]
        public ItemType RespawnAmmo_Private { get; set; } = ItemType.Ammo556x45;
        [Description("UNGOC列兵弹药数量 / UNGOC Private Personnel Ammos")]
        public ushort RespawnAmmos_Private { get; set; } = 60;
        [Description("UNGOC指挥官弹药类型 / UNGOC Captain Personnel Ammo Type")]
        public ItemType RespawnAmmo_Captain { get; set; } = ItemType.Ammo556x45;
        [Description("UNGOC指挥官弹药数量 / UNGOC Private Personnel Ammos")]
        public ushort RespawnAmmos_Captain { get; set; } = 100;
        [Description("UNGOC指挥官启用SCP1853效果 / Enable UNGOC Captain SCP1853 Effect")]
        public bool UNGOCCaptain_SCP1853Effect { get; set; } = true;
        
        [Description("UNGOC指挥官角色类型 / UNGOC Captain Role")]
        public RoleTypeId UNGOCCaptain_Role { get; set; } = RoleTypeId.NtfSergeant;
        [Description("UNGOC列兵角色类型 / UNGOC Private Role")]
        public RoleTypeId UNGOCPrivate_Role { get; set; } = RoleTypeId.NtfSpecialist;
        [Description("如果刷新UNGOC，则播报CASSIE广播文本 / If Respawn UNGOC , Send CASSIE Announcement text")]
        public string Announcement { get; set; } = "Attention all site Foundation personnel . U N G O C personnel into the facility gate B . G O C personnel will help NINETAILEDFOX containment all SCPSubjects";

        [Description("如果刷新UNGOC，则播报CASSIE广播本地化文本(语言文本) / If Respawn UNGOC , Send CASSIE Announcement Translation")]
        public string Announcement_Translation { get; set; } = "所有设施基金会人员注意<split>UNGOC人员已进入设施B大门，GOC人员将协助九尾狐收容所有SCP项目。";
        [Description("如果刷新UNGOC，则全图播报文本 / If Respawn UNGOC , Send Map Broadcast text")]
        public string Broadcast { get; set; } = "<size=65%>[<color=#00FFF6>C.A.S.S.I.E.</color>] 全球超自然联盟已进入设施协助基金会收容异常,请所有非战斗人员请撤离设施!</size>";
        [Description("UNGOC指挥官信息介绍 / UNGOC Captain Role Info")]
        public string UNGOCCaptain_Info { get; set; } = "<size=65%>你是 </size><size=100%><color=#00FFF6>\nUNGOC - 指挥官</color></size>\n<size=45%>与基金会合作\n------清除设施威胁------</size>";
        [Description("UNGOC列兵信息介绍 / UNGOC Private Role Info")]
        public string UNGOCPrivate_Info { get; set; } = "<size=65%>你是 </size><size=100%><color=#00FFF6>\nUNGOC - 作战专家</color></size>\n<size=45%>与基金会合作\n------清除设施威胁------</size>";
    }
}
