﻿
using System.Collections;
using System.Collections.Generic;
namespace MyLib {

public class RoleJobDescriptionsData : IConfig {

public int sheet;

public string tagIcon;

public string icon;

public int rotateSpeed;

public int baseSkill;

public int attackRange;

public int criticalHit;

public string ModelName;

public string DefaultWardrobe;

public string job;

public string descriptions;

public RoleJobDescriptionsData(int id1, int sheet1, string tagIcon1, string icon1, int rotateSpeed1, int baseSkill1, int attackRange1, int criticalHit1, string ModelName1, string DefaultWardrobe1, string job1, string descriptions1) {

id=id1;

sheet=sheet1;

tagIcon=tagIcon1;

icon=icon1;

rotateSpeed=rotateSpeed1;

baseSkill=baseSkill1;

attackRange=attackRange1;

criticalHit=criticalHit1;

ModelName=ModelName1;

DefaultWardrobe=DefaultWardrobe1;

job=job1;

descriptions=descriptions1;

}
}

public partial class GameData {

public static List<RoleJobDescriptionsData> RoleJobDescriptions = new List<RoleJobDescriptionsData>() {

new RoleJobDescriptionsData(1, 0, "TagZhanshi", "HeadZhanshi", 5, 1, 15, 0, "player/tank1", "", "战士", "战士拥有较高的血量和物理防御,擅长近身攻击<br>剑法:具有极高的爆发力<br>剑气:隔位攻击无视防御  "),

new RoleJobDescriptionsData(2, 0, "TagQiangshou", "HeadQiangshou", 5, 1, 15, 0, "player/tank1", "", "枪械师", "枪械师拥有最远的攻击距离,持续的物理伤害输出<br>箭术:擅长远程射击 <br>一次探险让他意识到了自己与生俱来的魔法威力<br>在探索恕瑞玛沙漠的金字塔时,他发现了一件拥有无尽能量的挂饰"),

new RoleJobDescriptionsData(3, 0, "TagCike", "HeadCike", 5, 1, 15, 0, "player/tank1", "", "潜杀者", "潜杀者拥有极高的物理爆发,杀人于无形<br>刺客艺术:隐身于暗处随时致命敌人<br>自从圣战以后,为了人类世界[米德加尔特],刺客要不断的杀戮来维持世界的平衡<br>因为人类总在一方强大之后侵犯别的国家<br>不过自从LOKI因为解决魔王梦罗克而没能及时赶回刺客工会后<br>刺客团就在SAKARY的手下永远消失了"),

};

}
}
