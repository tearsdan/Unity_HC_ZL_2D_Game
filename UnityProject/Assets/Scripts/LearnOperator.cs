using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3;
    public int c = 9, d = 1;

    public int apple = 5;
    public int coin = 3;

    public bool key;
    public int boom = 5;

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

        b = b + 10;
        b += 10;        // 適用 + - * / %

        // 比較運算子
        // 結果是布林值
        print(c > d);       // true
        print(c < d);       // false
        print(c >= d);      // true
        print(c <= d);      // false
        print(c == d);      // false
        print(c != d);      // true

        // 邏輯運算子
        // 結果是布林值
        // 並且 &&
        // 規則：只要有一個 false 就會傳回 false
        print(true && true);    // true
        print(true && false);   // false
        print(false && true);   // false
        print(false && false);  // false

        // 或者 ||
        // 規則：只要有一個 true 就會傳回 true
        print(true || true);    // true
        print(true || false);   // true
        print(false || true);   // true
        print(false || false);  // false

        // 相反 (顛倒) !
        // 作用：將布林值變相反
        print(!true);
        print(!false);

        // 任務：取得十個蘋果與五個金幣
        print(apple >= 10 && coin >= 5);

        // 任務：取得一個鑰匙或者兩個炸彈
        print(key && boom >= 2);
    }
}
