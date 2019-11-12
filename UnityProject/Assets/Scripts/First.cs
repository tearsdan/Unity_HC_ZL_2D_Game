using UnityEngine;  // 引用 Unity API

// 類別 類別名稱
public class First : MonoBehaviour
{
    // 定義欄位 Field (宣告變數)
    // 語法：
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 private   - 隱藏(預設)
    // 公開 public    - 顯示
    public int level = 1;               // 整數 預設 0
    public float speed = 10.5f;         // 浮點數 預設 0
    public string prop = "藍色藥水";    // 字串 預設 ""
    public bool mission = true;         // 布林值 預設 false
}
