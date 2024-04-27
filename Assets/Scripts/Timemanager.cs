using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager: MonoBehaviour
{
    [SerializeField, Header("時間文字")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 100)]
    private float timeTotal = 60;
    [SerializeField, Header("畫布遊戲結束")]
    private GameObject canvasFinalObject;
    [SerializeField, Header("檢查區域分數管理器")]
    private GameObject scoreManagerObject;
    [SerializeField, Header("按鈕生成籃球")]
    private Button btnSpawn;


    // 更新事件：一秒直行約 60 次
    private void Update()
    {
        CountDown();
    }
    private void CountDown()
    {
        // 時間 扣除 每幀的時間 (約為 1/60 秒)
        timeTotal -= Time.deltaTime;
        // 夾住數字 (數字，最小，最大)
        timeTotal = Mathf.Clamp(timeTotal, 0, 100);
        // 更新 時間文字
        textTime.text = $"TIME - {timeTotal.ToString("F0")}";

        // 如果 時間 等於 0 就呼叫遊戲結束方法
        if (timeTotal == 0) GameOver();
    }

    private void GameOver()
    {
        canvasFinalObject.SetActive(true);
        scoreManagerObject.SetActive(false);
        btnSpawn.interactable = false;
    }
}
