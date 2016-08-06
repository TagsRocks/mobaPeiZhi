
using System.Collections;
using System.Collections.Generic;
namespace MyLib {

public class LevelConfigData : IConfig {

public int rankOrDay;

public int rankRatio;

public int dayRatio;

public LevelConfigData(int rankOrDay1, int rankRatio1, int dayRatio1) {

rankOrDay=rankOrDay1;

rankRatio=rankRatio1;

dayRatio=dayRatio1;

}
}

public partial class GameData {

public static List<LevelConfigData> LevelConfig = new List<LevelConfigData>() {

new LevelConfigData(1, 200, 200),

new LevelConfigData(2, 180, 0),

new LevelConfigData(3, 150, 0),

new LevelConfigData(4, 120, 0),

new LevelConfigData(5, 120, 0),

new LevelConfigData(6, 120, 0),

new LevelConfigData(7, 120, 0),

new LevelConfigData(8, 120, 0),

new LevelConfigData(9, 100, 0),

new LevelConfigData(10, 100, 0),

new LevelConfigData(11, 100, 0),

new LevelConfigData(12, 100, 0),

};

}
}
