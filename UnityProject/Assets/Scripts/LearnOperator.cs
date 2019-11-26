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
    }
}
