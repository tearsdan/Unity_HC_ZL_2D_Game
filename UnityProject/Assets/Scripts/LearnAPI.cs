using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tranA;
    public Transform tranB;

    private void Start()
    {
        print("輸出!");


        // 靜態屬性：類別.屬性
        print(Random.value);

        // 練習取得 PI
        print(Mathf.PI);

        // 靜態方法：類別.方法(對應的參數);
        print("隨機範圍：" + Random.Range(50.5f, 100.9f));

        // object 任何類型：int、float、string、bool
        Debug.Log(true);
        Debug.LogWarning("警告");
        Debug.LogError("錯誤");

        // 非靜態屬性：實體類別.屬性
        print(tranA.position);
        print(tranB.position);
        // print(Transform.position); // 錯誤
    }

    private void Update()
    {
        // 輸入.按鍵名稱
        print(Input.inputString);

        // 練習：請練習偵測玩家有沒有按 s
        print(Input.GetKeyDown("s"));
    }
}
