using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法 Method (宣告函式、功能)
    // 語法：
    // 修飾詞 方法傳回類型 方法名稱 (參數) {  }
    // 參數語法：參數類型 參數名稱
    // void 無傳回
    private void Test()
    {

    }

    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">車子的速度</param>
    private void Drive(int speed)
    {
        print("引擎音效");
        // 字串可以使用 + 號與其他形態串接，結果為字串
        print("車子正在往前開，時速：" + speed);
    }

    private void Start()
    {
        // 呼叫方法，給予對應的引數
        Drive(99);
        Drive(999);
        Drive(9999999);
    }
}
