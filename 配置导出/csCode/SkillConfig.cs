
using System.Collections;
using System.Collections.Generic;
namespace MyLib {

public class SkillConfigData : IConfig {

public string name;

public int job;

public int sheet;

public int FullColdTime;

public string icon;

public string template;

public string animationName;

public int animationTime;

public string introduce;

public string effectSound;

public int lifeTime;

public bool stopMove;

public string hitSound;

public SkillConfigData(int id1, string name1, int job1, int sheet1, int FullColdTime1, string icon1, string template1, string animationName1, int animationTime1, string introduce1, string effectSound1, int lifeTime1, bool stopMove1, string hitSound1) {

id=id1;

name=name1;

job=job1;

sheet=sheet1;

FullColdTime=FullColdTime1;

icon=icon1;

template=template1;

animationName=animationName1;

animationTime=animationTime1;

introduce=introduce1;

effectSound=effectSound1;

lifeTime=lifeTime1;

stopMove=stopMove1;

hitSound=hitSound1;

}
}

public partial class GameData {

public static List<SkillConfigData> SkillConfig = new List<SkillConfigData>() {

new SkillConfigData(1, "普通近战攻击", -1, 0, 0, "", "explosive", "attack", 800, "普通近战攻击", "laserShoot", 5000, false, "paoDan3"),

new SkillConfigData(2, "普通远程攻击", -1, 0, 0, "", "bowAndArrow", "attack", 1000, "普通远程攻击", "", 5000, false, ""),

new SkillConfigData(28, "战士普通攻击", -1, 0, 0, "", "singleAttack", "", 1000, "", "", 5000, false, ""),

new SkillConfigData(7, "枪械师普通攻击", -1, 14, 0, "", "bowAndArrow", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(29, "炼金术师普通攻击", -1, 0, 0, "", "singleAttack", "", 1000, "", "", 5000, false, ""),

new SkillConfigData(30, "潜杀者普通攻击", -1, 0, 0, "", "singleAttack", "", 1000, "", "", 5000, false, ""),

new SkillConfigData(3, "冲击技能", -1, 14, 10000, "skill_bighit", "needles", "rslash_1", 1000, "发动全力猛烈向前一冲", "dash", 5000, false, "criticalhit1"),

new SkillConfigData(4, "重劈", -1, 14, 20000, "skill_dualwield", "burst", "rslash_1", 1000, "跳起之后，向下雷霆一击", "", 5000, false, "criticalhit2"),

new SkillConfigData(5, "回旋", -1, 14, 10000, "skill_chainvortex", "chains", "special_xuanlongsha", 1000, "快速旋转，带动空气杀人", "chainswing", 5000, false, "criticalhit3"),

new SkillConfigData(6, "直线地震", -1, 14, 0, "skill_seismicburst", "burst", "special_liedijue", 1000, "在自己前方召唤出地泉，攻击敌人", "slashing_swing", 5000, false, "slamshockwave"),

new SkillConfigData(8, "弹射技能", -1, 14, 10000, "skill_ricochet", "ricochet", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(9, "飞镖", -1, 14, 0, "skill_needlearc", "needles", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(10, "爆裂新星", -1, 14, 0, "skill_explosiveshot", "explosive", "special_longpao", 1000, "", "laserShoot", 5000, false, "paoDan3"),

new SkillConfigData(11, "火焰陷阱", -1, 14, 0, "skill_flametrap", "flametrap", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(12, "火焰陷阱火", -1, 0, 0, "", "flame", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(13, "陷阱生成技能", -1, 0, 0, "", "flametrapspawn", "", 1000, "", "", 5000, false, ""),

new SkillConfigData(14, "疯狂攻击", -1, 14, 0, "skill_slash", "whirlinggust", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(15, "炼狱", -1, 14, 0, "skill_quake", "quake", "rslash_1", 1000, "", "quake1", 5000, false, "slamshockwave"),

new SkillConfigData(16, "霜盾", -1, 14, 20000, "skill_frostshield", "frostshield", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(17, "火焰哨兵", -1, 14, 0, "skill_embersentry", "embersentry", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(18, "哨兵激光", -1, 0, 0, "", "beam", "attack", 2000, "", "", 5000, false, ""),

new SkillConfigData(19, "怪物单体攻击技能", -1, 0, 0, "", "monsterSingle", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(20, "流氓兔连击", -1, 0, 0, "", "liumangtuLianJi", "attack1", 1000, "", "", 5000, false, ""),

new SkillConfigData(21, "流氓兔跳跃攻击", -1, 0, 0, "", "liumangtuJump", "attack2", 1000, "", "", 5000, false, ""),

new SkillConfigData(22, "树桩滚动", -1, 0, 0, "", "treeRotate", "attack1", 1000, "", "", 5000, false, ""),

new SkillConfigData(23, "树桩跳跃", -1, 0, 0, "", "treeJump", "attack2", 1000, "", "", 5000, false, ""),

new SkillConfigData(24, "野猪震地", -1, 0, 0, "", "pigQuake", "attack1", 1000, "", "", 5000, false, ""),

new SkillConfigData(25, "野猪冲撞", -1, 0, 0, "", "pigRush", "attack2", 1000, "", "", 5000, false, ""),

new SkillConfigData(26, "地精远程攻击", -1, 0, 0, "", "bowAndArrow", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(27, "喷弹草攻击", -1, 0, 0, "", "grassArrow", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(100, "火炬之光怪物普通攻击", -1, 0, 0, "", "monsterSingle", "attack1", 1000, "", "", 5000, false, ""),

new SkillConfigData(101, "喷弹草攻击", -1, 0, 0, "", "grassArrow", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(102, "喷弹草攻击", -1, 0, 0, "", "grassArrow", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(103, "使用药水", -1, 0, 0, "icon_potion_health_small", "useDrug", "rslash_1", 1000, "", "", 5000, false, ""),

new SkillConfigData(104, "拳击兔攻击技能", -1, 0, 0, "", "monsterSingle", "attack", 800, "", "", 5000, false, ""),

new SkillConfigData(105, "酷儿冲跳", -1, 0, 0, "", "kuerRushJump", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(106, "魔王炼狱", -1, 14, 0, "skill_quake", "quake", "special_fan", 2000, "", "quake1", 5000, false, "slamshockwave"),

new SkillConfigData(107, "魔王单体攻击技能", -1, 0, 0, "", "SmallBossSingle", "attack1", 2000, "", "quake3", 5000, false, "criticalhit3"),

new SkillConfigData(108, "喷弹草腐蚀攻击", -1, 14, 20000, "skill_flametrap", "grassFushiArrow", "attack", 3000, "", "spiderspit1", 5000, false, "hugeimp1"),

new SkillConfigData(109, "火焰陷阱火持续伤害", -1, 0, 0, "", "flameHP", "attack", 2000, "", "loopfirelarge1", 5000, false, "fireimp1"),

new SkillConfigData(110, "地精远程攻击冰冻", -1, 0, 0, "", "bowAndArrowFrozen", "attack", 1000, "", "arrowhailwarmup", 5000, false, "arrowhailimpact"),

new SkillConfigData(111, "玩家跳跃", -1, 0, 0, "", "jump", "rslash_1", 3000, "", "quake1", 5000, false, "criticalhit1"),

new SkillConfigData(112, "母巢召唤喷弹草", -1, 0, 0, "", "penDanCaoSummon", "attack", 2000, "", "summon3", 5000, false, ""),

new SkillConfigData(113, "小喷弹草腐蚀攻击", -1, 0, 0, "", "grassFushiArrow2", "attack", 1000, "小喷弹草腐蚀攻击", "spiderspit1", 5000, false, "hugeimp1"),

new SkillConfigData(114, "魔王炼狱击退", -1, 14, 0, "skill_quake", "quake2", "special_fan", 1500, "", "quake1", 5000, false, "slamshockwave"),

new SkillConfigData(115, "魔王单体攻击技能2", -1, 0, 0, "", "mowangSingle", "attack1", 2000, "", "quake3", 5000, false, "criticalhit3"),

new SkillConfigData(116, "忍者自爆术", -1, 0, 0, "", "electricShock", "attack", 500, "", "emberlightningblast1", 5000, false, "emberbolthit"),

new SkillConfigData(117, "忍者闪烁术", -1, 0, 0, "", "ShanShuo", "attack", 2000, "", "palaceTeleport", 5000, false, "palaceTeleport"),

new SkillConfigData(118, "忍者反弹术", -1, 0, 0, "", "FanTan", "attack", 1000, "", "fireattack3", 5000, false, "loopfirelarge1"),

new SkillConfigData(119, "天皇单体攻击", -1, 0, 0, "", "TianHuangSingle", "attack", 1000, "", "fireattack3", 5000, false, "firegethit1"),

new SkillConfigData(120, "鬼魂化", -1, 0, 0, "", "Ghost", "attack", 1000, "", "emberlightningblast1", 5000, false, "emberbolthit"),

new SkillConfigData(121, "巨蚊冲刺", -1, 0, 0, "", "WenZiRush", "attack", 1000, "", "dash", 5000, false, "criticalhit1"),

new SkillConfigData(122, "幽冥雷", -1, 0, 0, "", "YouMingLight", "attack", 1000, "", "quake3", 5000, false, "slamshockwave"),

new SkillConfigData(123, "幽冥闪避", -1, 0, 0, "", "YouMingShanBi", "attack", 1000, "", "emberlightningblast1", 5000, false, "slamshockwave"),

new SkillConfigData(124, "神罚", -1, 0, 0, "", "ShenFa", "attack1", 1000, "", "quake3", 5000, false, "slamshockwave"),

new SkillConfigData(125, "群狼攻击", -1, 0, 0, "", "TianShenZhenFa", "attack", 1000, "降幅近的天神召集到一起", "palaceTeleport", 5000, false, "slamshockwave"),

new SkillConfigData(126, "狼王召唤", -1, 0, 0, "", "LangWangZhaoHuan", "attack", 1000, "召唤出一批狼崽", "summon3", 5000, false, "slamshockwave"),

new SkillConfigData(127, "狼王单体攻击技能", -1, 0, 0, "", "SmallBossSingle", "attack", 1000, "", "shockhit", 5000, false, "criticalhit3"),

new SkillConfigData(128, "翠花蛇灼烧buff", -1, 0, 0, "", "CuiHuaSheFire", "attack", 1000, "", "fireattack3", 5000, false, "criticalhit3"),

new SkillConfigData(129, "灼烧Buff造成伤害", -1, 0, 0, "", "CuiHuaFireDamage", "attack", 1000, "", "fireattack3", 5000, false, "criticalhit3"),

new SkillConfigData(130, "灰鼠复活", -1, 0, 0, "", "HuiShuRelive", "attack", 1000, "", "summon3", 5000, false, "summon3"),

new SkillConfigData(131, "掠夺金币", -1, 0, 0, "", "GoldStealSingle", "attack", 1000, "", "", 5000, false, "hugeimp1"),

new SkillConfigData(132, "音波冲击", -1, 14, 20000, "skill_flametrap", "SoundWave", "attack", 1000, "音波冲击", "arrowhailwarmup", 5000, false, "arrowhailimpact"),

new SkillConfigData(133, "嗜血", -1, 0, 0, "", "ShiXue", "attack", 1000, "", "shockhit", 5000, false, "shockhit"),

new SkillConfigData(134, "爆裂", -1, 0, 0, "", "BaoLie", "attack1", 3000, "", "shockhit", 5000, false, "slamshockwave"),

new SkillConfigData(135, "宝箱召唤boss", -1, 0, 0, "", "ChestSummon", "attack", 1000, "", "summon3", 5000, false, ""),

new SkillConfigData(136, "布鲁特火焰哨兵", -1, 14, 0, "skill_embersentry", "embersentry", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(137, "星球爆炸", -1, 0, 0, "", "BaoLie2", "attack", 1000, "", "shockhit", 5000, false, "slamshockwave"),

new SkillConfigData(138, "远程轰击击晕", -1, 0, 0, "", "bowAndArrowStun", "attack", 1000, "", "arrowhailwarmup", 5000, false, "arrowhailimpact"),

new SkillConfigData(139, "多重子弹轰击", -1, 0, 0, "", "MultiBowAndArrow", "attack", 1500, "", "arrowhailwarmup", 5000, false, "arrowhailimpact"),

new SkillConfigData(140, "冲击波", -1, 0, 0, "", "BowAndArrowKnockBack", "attack", 1500, "", "arrowhailwarmup", 5000, false, "arrowhailimpact"),

new SkillConfigData(141, "兔子冲刺", -1, 0, 0, "", "RabbitRush", "attack", 1000, "", "dash", 5000, false, "criticalhit1"),

new SkillConfigData(142, "盗贼暴击", -1, 0, 0, "", "DaoZeiCritical", "attack", 1000, "", "", 5000, false, "shockhit"),

new SkillConfigData(143, "炼狱击退", -1, 14, 0, "skill_quake", "quake3", "rslash_1", 1500, "", "quake1", 5000, false, "slamshockwave"),

new SkillConfigData(144, "哨兵激光-致盲", -1, 0, 0, "", "beam2", "attack", 2000, "", "emberlightningblast1", 5000, false, "emberbolthit"),

new SkillConfigData(145, "怪物单体攻击技能-沉默", -1, 0, 0, "", "monsterSingle2", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(146, "火焰陷阱火-减速", -1, 0, 0, "", "flame2", "attack", 1000, "", "", 5000, false, ""),

new SkillConfigData(147, "武器电Buff", -1, 0, 0, "", "weaponEle", "attack", 1000, "", "emberbolthit", 5000, false, "emberbolthit"),

new SkillConfigData(148, "电系武器减速", -1, 0, 0, "", "electricShock2", "attack", 500, "", "emberlightningblast1", 5000, false, "emberbolthit"),

new SkillConfigData(149, "投掷普通炸弹", -1, 0, 0, "", "bombSkill", "rslash_1", 1000, "投掷普通炸弹", "fireattack3", 5000, false, "firegethit1"),

new SkillConfigData(150, "增加MP的Buff", -1, 0, 0, "", "AddMpBuff", "rslash_1", 1000, "", "fireattack3", 5000, false, "firegethit1"),

new SkillConfigData(151, "增加HP的Buff", -1, 0, 0, "", "AddHPBuff", "", 1000, "", "fireattack3", 5000, false, "firegethit1"),

new SkillConfigData(152, "连发的Buff", -1, 0, 0, "", "LianFaBuff", "", 1000, "", "fireattack3", 5000, false, "firegethit1"),

new SkillConfigData(153, "冲锋技能", -1, 14, 1000, "skill_bighit", "rushSkill", "rslash_1", 1000, "发动全力猛烈向前一冲", "dash", 5000, false, "criticalhit1"),

new SkillConfigData(154, "反弹盾", 1, 14, 14000, "skill_frostshield", "fanTanShield", "", 1000, "", "", 5000, false, ""),

new SkillConfigData(155, "静态射击", 1, 14, 14000, "skill_frostshield", "AddStaticShootBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(156, "超能子弹", 1, 14, 14000, "skill_frostshield", "superShoot", "rslash_1", 1001, "", "laserShoot", 5000, false, "paoDan3"),

new SkillConfigData(157, "超能子弹Buff", 1, 14, 14000, "skill_frostshield", "superShootBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(158, "辐射区域伤害Buff", 1, 14, 14000, "skill_frostshield", "DamageHP", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(159, "隐身药水Buff", 1, 14, 14000, "skill_frostshield", "HideBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(160, "原子弹", 1, 14, 14000, "skill_frostshield", "Nuclear", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(161, "原子弹Buff", 1, 14, 14000, "skill_frostshield", "NuclearBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(162, "原子弹辐射伤害", 1, 14, 14000, "skill_frostshield", "NuclearDamageHP", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(163, "击退技能Buff", 1, 14, 14000, "skill_frostshield", "KnockBack", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(164, "击退技能", 1, 14, 14000, "skill_frostshield", "KnockBackSkill", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(165, "无敌", 1, 14, 14000, "skill_frostshield", "WuDi", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(166, "导弹装置", 1, 14, 14000, "skill_frostshield", "DaoDanBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(167, "导弹", 1, 14, 14000, "skill_frostshield", "DaoDan", "rslash_1", 1001, "", "laserShoot", 5000, false, "paoDan3"),

new SkillConfigData(168, "激光发射器", 1, 14, 14000, "skill_frostshield", "LaserBuff", "rslash_1", 1001, "", "laserShoot", 5000, false, "paoDan3"),

new SkillConfigData(169, "激光", 1, 14, 14000, "skill_frostshield", "Laser", "rslash_1", 5000, "", "laserShoot", 8000, true, "paoDan3"),

new SkillConfigData(170, "激光辐射伤害", 1, 14, 14000, "skill_frostshield", "LaserDamageHP", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(171, "引力发生器", 1, 14, 14000, "skill_frostshield", "GouSuoBuff", "rslash_1", 1001, "", "", 5000, false, ""),

new SkillConfigData(172, "引力", 1, 14, 14000, "skill_frostshield", "GouSuo", "rslash_1", 3000, "", "", 5000, true, ""),

};

}
}
