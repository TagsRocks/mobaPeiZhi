
using System.Collections;
using System.Collections.Generic;
namespace MyLib {

public class RoleUpgradeConfigData : IConfig {

public int level;

public int job;

public long exp;

public int maxHp;

public int maxMp;

public int attack;

public int defense;

public int baseExp;

public int extraExp;

public RoleUpgradeConfigData(int id1, int level1, int job1, long exp1, int maxHp1, int maxMp1, int attack1, int defense1, int baseExp1, int extraExp1) {

id=id1;

level=level1;

job=job1;

exp=exp1;

maxHp=maxHp1;

maxMp=maxMp1;

attack=attack1;

defense=defense1;

baseExp=baseExp1;

extraExp=extraExp1;

}
}

public partial class GameData {

public static List<RoleUpgradeConfigData> RoleUpgradeConfig = new List<RoleUpgradeConfigData>() {

new RoleUpgradeConfigData(10001, 1, 1, 5200, 100, 100, 20, 0, 1000, 1100),

new RoleUpgradeConfigData(10002, 2, 1, 5700, 100, 100, 20, 0, 1100, 1210),

new RoleUpgradeConfigData(10003, 3, 1, 6200, 100, 100, 20, 0, 1200, 1320),

new RoleUpgradeConfigData(10004, 4, 1, 8700, 100, 100, 20, 0, 1300, 1430),

new RoleUpgradeConfigData(10005, 5, 1, 9400, 100, 100, 20, 0, 1400, 1540),

new RoleUpgradeConfigData(10006, 6, 1, 10100, 100, 100, 20, 0, 1500, 1650),

new RoleUpgradeConfigData(10007, 7, 1, 13100, 100, 100, 20, 0, 1600, 1760),

new RoleUpgradeConfigData(10008, 8, 1, 13900, 100, 100, 20, 0, 1700, 1870),

new RoleUpgradeConfigData(10009, 9, 1, 14800, 100, 100, 20, 0, 1800, 1980),

new RoleUpgradeConfigData(10010, 10, 1, 18400, 100, 100, 20, 0, 1900, 2090),

new RoleUpgradeConfigData(10011, 11, 1, 19400, 100, 100, 20, 0, 2000, 2200),

new RoleUpgradeConfigData(10012, 12, 1, 20400, 100, 100, 20, 0, 2100, 2310),

new RoleUpgradeConfigData(10013, 13, 1, 21300, 100, 100, 20, 0, 2200, 2420),

new RoleUpgradeConfigData(10014, 14, 1, 22300, 100, 100, 20, 0, 2300, 2530),

new RoleUpgradeConfigData(10015, 15, 1, 23300, 100, 100, 20, 0, 2400, 2640),

new RoleUpgradeConfigData(10016, 16, 1, 28000, 100, 100, 20, 0, 2500, 2750),

new RoleUpgradeConfigData(10017, 17, 1, 29100, 100, 100, 20, 0, 2600, 2860),

new RoleUpgradeConfigData(10018, 18, 1, 30200, 100, 100, 20, 0, 2700, 2970),

new RoleUpgradeConfigData(10019, 19, 1, 31400, 100, 100, 20, 0, 2800, 3080),

new RoleUpgradeConfigData(10020, 20, 1, 36800, 100, 100, 20, 0, 2900, 3190),

new RoleUpgradeConfigData(10021, 21, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10022, 22, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10023, 23, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10024, 24, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10025, 25, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10026, 26, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10027, 27, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10028, 28, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10029, 29, 1, 38100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10030, 30, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10031, 31, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10032, 32, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10033, 33, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10034, 34, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10035, 35, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10036, 36, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10037, 37, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10038, 38, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10039, 39, 1, 42600, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10040, 40, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10041, 41, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10042, 42, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10043, 43, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10044, 44, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10045, 45, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10046, 46, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10047, 47, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10048, 48, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10049, 49, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(10050, 50, 1, 47100, 100, 100, 20, 0, 3000, 3300),

new RoleUpgradeConfigData(20001, 1, 2, 4000, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20002, 2, 2, 9412, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20003, 3, 2, 17404, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20004, 4, 2, 28246, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20005, 5, 2, 42022, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20006, 6, 2, 58942, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20007, 7, 2, 79102, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20008, 8, 2, 108569, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20009, 9, 2, 131231, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20010, 10, 2, 157972, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20011, 11, 2, 188832, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20012, 12, 2, 223852, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20013, 13, 2, 263071, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20014, 14, 2, 306531, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20015, 15, 2, 354270, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20016, 16, 2, 406330, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20017, 17, 2, 462749, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20018, 18, 2, 523570, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20019, 19, 2, 588830, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20020, 20, 2, 658572, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20021, 21, 2, 732834, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20022, 22, 2, 811657, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20023, 23, 2, 895081, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20024, 24, 2, 983146, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20025, 25, 2, 1075893, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20026, 26, 2, 1173361, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20027, 27, 2, 1275591, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20028, 28, 2, 1382622, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20029, 29, 2, 1494496, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20030, 30, 2, 1611252, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20031, 31, 2, 1732929, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20032, 32, 2, 1859569, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20033, 33, 2, 1991212, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20034, 34, 2, 2127897, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20035, 35, 2, 2269665, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20036, 36, 2, 2416556, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20037, 37, 2, 2568610, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20038, 38, 2, 2725867, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20039, 39, 2, 2888368, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20040, 40, 2, 3056152, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20041, 41, 2, 3229259, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20042, 42, 2, 3407730, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20043, 43, 2, 3591605, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20044, 44, 2, 3780924, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20045, 45, 2, 3975728, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20046, 46, 2, 4176055, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20047, 47, 2, 4381947, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20048, 48, 2, 4593444, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20049, 49, 2, 4810585, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(20050, 50, 2, 5033412, 40, 100, 20, 0, 200, 444),

new RoleUpgradeConfigData(30001, 1, 3, 4000, 20, 80, 100, 0, 200, 444),

new RoleUpgradeConfigData(30002, 2, 3, 9412, 20, 90, 100, 0, 200, 444),

new RoleUpgradeConfigData(30003, 3, 3, 17404, 20, 100, 100, 0, 200, 444),

new RoleUpgradeConfigData(30004, 4, 3, 28246, 20, 110, 100, 0, 200, 444),

new RoleUpgradeConfigData(30005, 5, 3, 42022, 20, 120, 100, 0, 200, 444),

new RoleUpgradeConfigData(30006, 6, 3, 58942, 20, 130, 100, 0, 200, 444),

new RoleUpgradeConfigData(30007, 7, 3, 79102, 20, 140, 100, 0, 200, 444),

new RoleUpgradeConfigData(30008, 8, 3, 108569, 20, 150, 100, 0, 200, 444),

new RoleUpgradeConfigData(30009, 9, 3, 131231, 20, 160, 100, 0, 200, 444),

new RoleUpgradeConfigData(30010, 10, 3, 157972, 20, 170, 100, 0, 200, 444),

new RoleUpgradeConfigData(30011, 11, 3, 188832, 20, 180, 100, 0, 200, 444),

new RoleUpgradeConfigData(30012, 12, 3, 223852, 20, 190, 100, 0, 200, 444),

new RoleUpgradeConfigData(30013, 13, 3, 263071, 20, 200, 100, 0, 200, 444),

new RoleUpgradeConfigData(30014, 14, 3, 306531, 20, 210, 100, 0, 200, 444),

new RoleUpgradeConfigData(30015, 15, 3, 354270, 20, 220, 100, 0, 200, 444),

new RoleUpgradeConfigData(30016, 16, 3, 406330, 20, 230, 100, 0, 200, 444),

new RoleUpgradeConfigData(30017, 17, 3, 462749, 20, 240, 100, 0, 200, 444),

new RoleUpgradeConfigData(30018, 18, 3, 523570, 20, 250, 100, 0, 200, 444),

new RoleUpgradeConfigData(30019, 19, 3, 588830, 20, 260, 100, 0, 200, 444),

new RoleUpgradeConfigData(30020, 20, 3, 658572, 20, 270, 100, 0, 200, 444),

new RoleUpgradeConfigData(30021, 21, 3, 732834, 20, 280, 100, 0, 200, 444),

new RoleUpgradeConfigData(30022, 22, 3, 811657, 20, 290, 100, 0, 200, 444),

new RoleUpgradeConfigData(30023, 23, 3, 895081, 20, 300, 100, 0, 200, 444),

new RoleUpgradeConfigData(30024, 24, 3, 983146, 20, 310, 100, 0, 200, 444),

new RoleUpgradeConfigData(30025, 25, 3, 1075893, 20, 320, 100, 0, 200, 444),

new RoleUpgradeConfigData(30026, 26, 3, 1173361, 20, 330, 100, 0, 200, 444),

new RoleUpgradeConfigData(30027, 27, 3, 1275591, 20, 340, 100, 0, 200, 444),

new RoleUpgradeConfigData(30028, 28, 3, 1382622, 20, 350, 100, 0, 200, 444),

new RoleUpgradeConfigData(30029, 29, 3, 1494496, 20, 360, 100, 0, 200, 444),

new RoleUpgradeConfigData(30030, 30, 3, 1611252, 20, 370, 100, 0, 200, 444),

new RoleUpgradeConfigData(30031, 31, 3, 1732929, 20, 380, 100, 0, 200, 444),

new RoleUpgradeConfigData(30032, 32, 3, 1859569, 20, 390, 100, 0, 200, 444),

new RoleUpgradeConfigData(30033, 33, 3, 1991212, 20, 400, 100, 0, 200, 444),

new RoleUpgradeConfigData(30034, 34, 3, 2127897, 20, 410, 100, 0, 200, 444),

new RoleUpgradeConfigData(30035, 35, 3, 2269665, 20, 420, 100, 0, 200, 444),

new RoleUpgradeConfigData(30036, 36, 3, 2416556, 20, 430, 100, 0, 200, 444),

new RoleUpgradeConfigData(30037, 37, 3, 2568610, 20, 440, 100, 0, 200, 444),

new RoleUpgradeConfigData(30038, 38, 3, 2725867, 20, 450, 100, 0, 200, 444),

new RoleUpgradeConfigData(30039, 39, 3, 2888368, 20, 460, 100, 0, 200, 444),

new RoleUpgradeConfigData(30040, 40, 3, 3056152, 20, 470, 100, 0, 200, 444),

new RoleUpgradeConfigData(30041, 41, 3, 3229259, 20, 480, 100, 0, 200, 444),

new RoleUpgradeConfigData(30042, 42, 3, 3407730, 20, 490, 100, 0, 200, 444),

new RoleUpgradeConfigData(30043, 43, 3, 3591605, 20, 500, 100, 0, 200, 444),

new RoleUpgradeConfigData(30044, 44, 3, 3780924, 20, 510, 100, 0, 200, 444),

new RoleUpgradeConfigData(30045, 45, 3, 3975728, 20, 520, 100, 0, 200, 444),

new RoleUpgradeConfigData(30046, 46, 3, 4176055, 20, 530, 100, 0, 200, 444),

new RoleUpgradeConfigData(30047, 47, 3, 4381947, 20, 540, 100, 0, 200, 444),

new RoleUpgradeConfigData(30048, 48, 3, 4593444, 20, 550, 100, 0, 200, 444),

new RoleUpgradeConfigData(30049, 49, 3, 4810585, 20, 560, 100, 0, 200, 444),

new RoleUpgradeConfigData(30050, 50, 3, 5033412, 20, 570, 100, 0, 200, 444),

new RoleUpgradeConfigData(40001, 1, 4, 4000, 130, 80, 13, 0, 200, 444),

new RoleUpgradeConfigData(40002, 2, 4, 9412, 140, 90, 15, 0, 200, 444),

new RoleUpgradeConfigData(40003, 3, 4, 17404, 150, 100, 17, 0, 200, 444),

new RoleUpgradeConfigData(40004, 4, 4, 28246, 160, 110, 19, 0, 200, 444),

new RoleUpgradeConfigData(40005, 5, 4, 42022, 170, 120, 21, 0, 200, 444),

new RoleUpgradeConfigData(40006, 6, 4, 58942, 180, 130, 23, 0, 200, 444),

new RoleUpgradeConfigData(40007, 7, 4, 79102, 190, 140, 25, 0, 200, 444),

new RoleUpgradeConfigData(40008, 8, 4, 108569, 200, 150, 27, 0, 200, 444),

new RoleUpgradeConfigData(40009, 9, 4, 131231, 210, 160, 29, 0, 200, 444),

new RoleUpgradeConfigData(40010, 10, 4, 157972, 220, 170, 31, 0, 200, 444),

new RoleUpgradeConfigData(40011, 11, 4, 188832, 230, 180, 33, 0, 200, 444),

new RoleUpgradeConfigData(40012, 12, 4, 223852, 240, 190, 35, 0, 200, 444),

new RoleUpgradeConfigData(40013, 13, 4, 263071, 250, 200, 37, 0, 200, 444),

new RoleUpgradeConfigData(40014, 14, 4, 306531, 260, 210, 39, 0, 200, 444),

new RoleUpgradeConfigData(40015, 15, 4, 354270, 270, 220, 41, 0, 200, 444),

new RoleUpgradeConfigData(40016, 16, 4, 406330, 280, 230, 43, 0, 200, 444),

new RoleUpgradeConfigData(40017, 17, 4, 462749, 290, 240, 45, 0, 200, 444),

new RoleUpgradeConfigData(40018, 18, 4, 523570, 300, 250, 47, 0, 200, 444),

new RoleUpgradeConfigData(40019, 19, 4, 588830, 310, 260, 49, 0, 200, 444),

new RoleUpgradeConfigData(40020, 20, 4, 658572, 320, 270, 51, 0, 200, 444),

new RoleUpgradeConfigData(40021, 21, 4, 732834, 330, 280, 53, 0, 200, 444),

new RoleUpgradeConfigData(40022, 22, 4, 811657, 340, 290, 55, 0, 200, 444),

new RoleUpgradeConfigData(40023, 23, 4, 895081, 350, 300, 57, 0, 200, 444),

new RoleUpgradeConfigData(40024, 24, 4, 983146, 360, 310, 59, 0, 200, 444),

new RoleUpgradeConfigData(40025, 25, 4, 1075893, 370, 320, 61, 0, 200, 444),

new RoleUpgradeConfigData(40026, 26, 4, 1173361, 380, 330, 63, 0, 200, 444),

new RoleUpgradeConfigData(40027, 27, 4, 1275591, 390, 340, 65, 0, 200, 444),

new RoleUpgradeConfigData(40028, 28, 4, 1382622, 400, 350, 67, 0, 200, 444),

new RoleUpgradeConfigData(40029, 29, 4, 1494496, 410, 360, 69, 0, 200, 444),

new RoleUpgradeConfigData(40030, 30, 4, 1611252, 420, 370, 71, 0, 200, 444),

new RoleUpgradeConfigData(40031, 31, 4, 1732929, 430, 380, 73, 0, 200, 444),

new RoleUpgradeConfigData(40032, 32, 4, 1859569, 440, 390, 75, 0, 200, 444),

new RoleUpgradeConfigData(40033, 33, 4, 1991212, 450, 400, 77, 0, 200, 444),

new RoleUpgradeConfigData(40034, 34, 4, 2127897, 460, 410, 79, 0, 200, 444),

new RoleUpgradeConfigData(40035, 35, 4, 2269665, 470, 420, 81, 0, 200, 444),

new RoleUpgradeConfigData(40036, 36, 4, 2416556, 480, 430, 83, 0, 200, 444),

new RoleUpgradeConfigData(40037, 37, 4, 2568610, 490, 440, 85, 0, 200, 444),

new RoleUpgradeConfigData(40038, 38, 4, 2725867, 500, 450, 87, 0, 200, 444),

new RoleUpgradeConfigData(40039, 39, 4, 2888368, 510, 460, 89, 0, 200, 444),

new RoleUpgradeConfigData(40040, 40, 4, 3056152, 520, 470, 91, 0, 200, 444),

new RoleUpgradeConfigData(40041, 41, 4, 3229259, 530, 480, 93, 0, 200, 444),

new RoleUpgradeConfigData(40042, 42, 4, 3407730, 540, 490, 95, 0, 200, 444),

new RoleUpgradeConfigData(40043, 43, 4, 3591605, 550, 500, 97, 0, 200, 444),

new RoleUpgradeConfigData(40044, 44, 4, 3780924, 560, 510, 99, 0, 200, 444),

new RoleUpgradeConfigData(40045, 45, 4, 3975728, 570, 520, 101, 0, 200, 444),

new RoleUpgradeConfigData(40046, 46, 4, 4176055, 580, 530, 103, 0, 200, 444),

new RoleUpgradeConfigData(40047, 47, 4, 4381947, 590, 540, 105, 0, 200, 444),

new RoleUpgradeConfigData(40048, 48, 4, 4593444, 600, 550, 107, 0, 200, 444),

new RoleUpgradeConfigData(40049, 49, 4, 4810585, 610, 560, 109, 0, 200, 444),

new RoleUpgradeConfigData(40050, 50, 4, 5033412, 620, 570, 111, 0, 200, 444),

};

}
}
