using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    private int score = 0;
    private float elapsedTime = 0f;
    private int highScore;
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore",0);
        score = PlayerPrefs.GetInt("score", 0);
        UpdateScoreUI();
    }
    private void Update()
    {
        // Cập nhật thời gian đã trôi qua
        elapsedTime += Time.deltaTime;

        // Kiểm tra nếu đã trôi qua 1 giây
        if (elapsedTime >= 1f)
        {
            // Tính điểm và reset thời gian
            AddScore(1);
            if(score>highScore){
                highScore=score;
                PlayerPrefs.SetInt("highscore",score);
            }
            elapsedTime = 0f;
        }
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
