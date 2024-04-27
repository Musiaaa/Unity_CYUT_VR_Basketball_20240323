using TMPro;
using UnityEngine;

public class Timemanager: MonoBehaviour
{
    [SerializeField, Header("�ɶ���r")]
    private TMP_Text textTime;
    [SerializeField, Header("�˼Ʈɶ�"), Range(10, 100)]
    private float timeTotal = 60;

    private void Update()
    {
        CountDown();
    }
    private void CountDown()
    {
        // �ɶ� ���� �C�V���ɶ� (���� 1/60 ��)
        timeTotal -= Time.deltaTime;
        // ��s �ɶ���r
        textTime.text = $"TIME - {timeTotal}";
    }
}
