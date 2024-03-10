using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " Points";
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void Add2Points()
    {
        score += 2;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void Add3Points()
    {
        score += 3;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void Add4Points()
    {
        score += 4;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void Add5Points()
    {
        score += 5;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }

    public void Add6Points()
    {
        score += 6;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
