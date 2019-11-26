using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;

    private void Start()
    {
        // 數學運算子
        // + - * / %
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;      // 等號右邊先執行再存回左邊
        print(a++);     // 先輸出再執行遞增
        print(++a);     // 先執行遞增再輸出
    }
}
