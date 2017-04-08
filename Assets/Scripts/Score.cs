using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    public Text currentScoreText;
    public Text highScoreText;
    [HideInInspector]
    public static int CurrentScore = 0;

    private int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();
        currentScoreText.text = CurrentScore.ToString();
    }

    private void LateUpdate()
    {
        currentScoreText.text = CurrentScore.ToString();
        if(highScore < CurrentScore)
        {
            highScore = CurrentScore;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
