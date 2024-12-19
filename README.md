![image](https://github.com/MengXinSheQu/UNGOC/blob/main/image/image_1.png)
# English && Chinese
# English - UNGOC
## UNGOC is EXILED Plugin

UNGOC[Ntf Team] can spawn in this Plugin.

## Installation:

Frist, Place the files in the dependencies.zip folder in the %appdata%\Exiled\Plugins\dependencies folder.

Next, Place the UNGOC.dll in the %appdata%\Exiled\Plugins folder.

Finally, You Can Enbale RespawnMusic in Plugin's Config, If "EnableMusic" is true , You need set "MusicPath" and place music in path.

## [English]Config - Default:

```
u_n_g_o_c_u_n_g_o_c_plugin:
//If Respawn Ntf , What times will spawn UNGOC? (If 0 , Skip)
spawn_times: 1
//If Respawn UNGOC , Enable Announcement
enable_announcement: true
//If Respawn UNGOC , Send CASSIE Announcement text
announcement: 'Attention all site Foundation personnel . U N G O C personnel into the facility gate B . G O C personnel will help NINETAILEDFOX containment all SCPSubjects'

//If Respawn UNGOC , Send CASSIE Announcement Translation
announcement\_\_translation: 'Attention all site Foundation personnel . GOC Personnel into the facility Gate-B . GOC personnel will help Nine Tailed Fox Containment all SCPSubjects'

//If Respawn UNGOC , Enable Map Broadcast
enable_broadcast: true
//If Respawn UNGOC , Send Map Broadcast text
broadcast: '<size=65%>[<color=#00FFF6>C.A.S.S.I.E.</color>] UNGOC has entered the Facility!</size>'

//UNGOC Captain Item List
respawn_items\_\_captain:

- GunFRMG0
- ArmorHeavy
- Adrenaline
- Medkit
- GrenadeHE
- KeycardMTFCaptain
- Radio

//Enable UNGOC Captain SCP1853 Effect
u_n_g_o_c_captain\_\_s_c_p1853_effect: true

//UNGOC Private Personnel Item List
respawn_items\_\_private:

- GunE11SR
- ArmorCombat
- Adrenaline
- Medkit
- KeycardMTFOperative
- Radio

//UNGOC Captain Role Info
u_n_g_o_c_captain**info: |-
<size=65%>You are </size><size=100%><color=#00FFF6>
UNGOC - Captain</color></size>
<size=45%>Help MTF
------Contained All SCP Subjects------</size>
//UNGOC Private Role Info
u_n_g_o_c_private**info: |-
<size=65%>You are </size><size=100%><color=#00FFF6>
UNGOC - Private</color></size>
<size=45%>Help MTF
------Contained All SCP Subjects------</size>
//UNGOC Captain Role
u_n_g_o_c_captain\_\_role: NtfCaptain

//UNGOC Private Role
u_n_g_o_c_private\_\_role: NtfSpecialist

//Enable UNGOC Respawn Music
enable_music: true

//UNGOC Respawn Music Path
music_path: '%appdata%\EXILED\UNGOC.ogg'
```

# 中文 - UNGOC

## UNGOC为EXILED插件

UNGOC[Ntf阵营] 能够在这个插件生成。
你可以自由的设置配置文件项，来控制这个插件。

## 安装:

首先, 将 dependencies.zip 放到 %appdata%\Exiled\Plugins\dependencies 目录内。

其次, 将 UNGOC.dll 放到 %appdata%\Exiled\Plugins 目录内。

最后, 你可以在配置文件中设置是否启动音乐, 如果启动音乐, 你需要设置音乐路径并把音乐放在路径位置(48000采样率 单声道ogg格式).

## 中文 Config - 默认:

```

//如果刷新九尾狐，第几次将刷新UNGOC(如果为0则跳过)
  spawn_times: 1

//如果刷新UNGOC，启动广播
  enable_announcement: true

//如果刷新UNGOC，则播报CASSIE广播文本
  announcement: 'Attention all site Foundation personnel . U N G O C personnel into the facility gate B . G O C personnel will help NINETAILEDFOX containment all SCPSubjects'

//如果刷新UNGOC，则播报CASSIE广播本地化文本(语言文本)
  announcement__translation: '所有设施基金会人员注意<split>UNGOC人员已进入设施B大门，GOC人员将协助九尾狐收容所有SCP项目。'

//如果刷新UNGOC，启动全图播报Broadcase
  enable_broadcast: true

//如果刷新UNGOC，则全图播报文本
  broadcast: '<size=65%>[<color=#00FFF6>C.A.S.S.I.E.</color>] 全球超自然联盟已进入设施协助基金会收容异常,请所有非战斗人员请撤离设施!</size>'

//UNGOC指挥官物品 / UNGOC Captain Item List
  respawn_items__captain:
  - GunFRMG0
  - ArmorHeavy
  - Adrenaline
  - Medkit
  - GrenadeHE
  - KeycardMTFCaptain
  - Radio

//UNGOC指挥官启用SCP1853效果
  u_n_g_o_c_captain__s_c_p1853_effect: true

//UNGOC列兵物品
  respawn_items__private:
  - GunE11SR
  - ArmorCombat
  - Adrenaline
  - Medkit
  - KeycardMTFOperative
  - Radio

//UNGOC指挥官信息介绍
  u_n_g_o_c_captain__info: |-
    <size=65%>你是 </size><size=100%><color=#00FFF6>
    UNGOC - 指挥官</color></size>
    <size=45%>与基金会合作
    ------清除设施威胁------</size>

//UNGOC列兵信息介绍
  u_n_g_o_c_private__info: |-
    <size=65%>你是 </size><size=100%><color=#00FFF6>
    UNGOC - 作战专家</color></size>
    <size=45%>与基金会合作
    ------清除设施威胁------</size>

  # UNGOC指挥官角色类型 / UNGOC Captain Role
  u_n_g_o_c_captain__role: NtfCaptain

  # UNGOC列兵角色类型 / UNGOC Private Role
  u_n_g_o_c_private__role: NtfSpecialist

  # 启动UNGOC刷新音乐 / Enable UNGOC Respawn Music
  enable_music: true

  # UNGOC刷新音乐路径 / UNGOC Respawn Music Path
  music_path: '%appdata%\EXILED\UNGOC.ogg'
```
