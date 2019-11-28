using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;

    private void Start()
    {
        // 判斷式 if (switch)
        // 語法：
        // if (布林值) { 當 if () 布林值為 true 執行這裡 }

        if (true)
        {
            print("嗨~");
        }
    }

    private void Update()
    {
        // if () 布林值為 true 會執行 if {}
        if (open)
        {
            print("開門!");
        }
        // if () 布林值為 false 會執行 else {} (否則)
        else
        {
            print("關門!");
        }
    }
}
