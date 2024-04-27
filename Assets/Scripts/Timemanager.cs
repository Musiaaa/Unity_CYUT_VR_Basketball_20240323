using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager: MonoBehaviour
{
    [SerializeField, Header("�ɶ���r")]
    private TMP_Text textTime;
    [SerializeField, Header("�˼Ʈɶ�"), Range(10, 100)]
    private float timeTotal = 60;
    [SerializeField, Header("�e���C������")]
    private GameObject canvasFinalObject;
    [SerializeField, Header("�ˬd�ϰ���ƺ޲z��")]
    private GameObject scoreManagerObject;
    [SerializeField, Header("���s�ͦ��x�y")]
    private Button btnSpawn;


    // ��s�ƥ�G�@����� 60 ��
    private void Update()
    {
        CountDown();
    }
    private void CountDown()
    {
        // �ɶ� ���� �C�V���ɶ� (���� 1/60 ��)
        timeTotal -= Time.deltaTime;
        // ����Ʀr (�Ʀr�A�̤p�A�̤j)
        timeTotal = Mathf.Clamp(timeTotal, 0, 100);
        // ��s �ɶ���r
        textTime.text = $"TIME - {timeTotal.ToString("F0")}";

        // �p�G �ɶ� ���� 0 �N�I�s�C��������k
        if (timeTotal == 0) GameOver();
    }

    private void GameOver()
    {
        canvasFinalObject.SetActive(true);
        scoreManagerObject.SetActive(false);
        btnSpawn.interactable = false;
    }
}
