using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int TotalEnemy , Score , TotalCollectable;

    public static GameManager Instance;
    public Text ScoreText, TotalEnemyText , FailedWinnerText , TotalCollectText;
    public GameObject FaildWinObject;

    public UnityEvent Event;

    private void Awake() => Instance = this;
    private void Start() =>  StartCoroutine("StartEvent");

    public void ShowInfo()
    {
        Debug.Log("OK");
        TotalEnemyText.text = TotalEnemy.ToString();
        ScoreText.text = Score.ToString();
        TotalCollectText.text = TotalCollectable.ToString();

        if (TotalEnemy < 1 && TotalCollectable < 1)
        {
            FaildWinObject.SetActive(true);
            FailedWinnerText.text = "You Succeeded";
            FailedWinnerText.color = Color.green;
        }
    }

    public IEnumerator StartEvent()
    {
        yield return new WaitForSeconds(1f);
        Event?.Invoke();
    }
}
