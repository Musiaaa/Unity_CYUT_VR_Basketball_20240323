﻿using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    [SerializeField, Header("分數文字")]
    private TMP_Text textScore;

    private string basketballName = "籃球";
    private int score;

    // 觸發開始事件：兩個物件碰撞開始執行一次
    // 條件：
    // 1.兩個物件都必須要有碰撞器
    // 2.其中一個物件要有剛體
    private void OnTriggerEnter(Collider other)
    {
        // print(other.name);

        // 如果 進入的物件名稱 包含 籃球
        // 就加兩分
        if (other.name.Contains(basketballName))
        {
            score += 2;
            // print($"<color=#f93>分數：{score}</color>");
            textScore.text = $"SCORE - {score}";
        }
    }
}
