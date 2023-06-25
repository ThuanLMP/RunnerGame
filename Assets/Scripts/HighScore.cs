using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI hightScoreText;
    const string HightScrorePrefix = "High Score: ";
    void Start()
    {
        int highScore = PlayerPrefs.GetInt("highscore",0);
        hightScoreText.text = HightScrorePrefix + highScore.ToString();
    }
}
