using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int TotalEnemy , Score , TotalCollectable;

    public static GameManager Instance;
    public Text ScoreText, TotalEnemyText , FailedWinnerText , TotalCollectText;
    public GameObject FaildWinObject;
    private void Awake() => Instance = this;
    
    public void ShowInfo()
    {
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
}
