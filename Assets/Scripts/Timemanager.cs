using TMPro;
using UnityEngine;

public class Timemanager: MonoBehaviour
{
    [SerializeField, Header("時間文字")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間"), Range(10, 100)]
    private float timeTotal = 60;

    private void Update()
    {
        CountDown();
    }
    private void CountDown()
    {
        // 時間 扣除 每幀的時間 (約為 1/60 秒)
        timeTotal -= Time.deltaTime;
        // 更新 時間文字
        textTime.text = $"TIME - {timeTotal}";
    }
}
