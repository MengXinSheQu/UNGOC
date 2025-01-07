using Exiled.API.Interfaces;
using System.ComponentModel;

namespace UNGOC
{
    public class Translation : ITranslation
    {
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
