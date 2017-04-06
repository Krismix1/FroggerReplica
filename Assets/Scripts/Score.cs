using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    public Text scoreText;
    public static int CurrentScore = 0;

    private void Start()
    {
        scoreText.text = CurrentScore.ToString();
    }

    private void LateUpdate()
    {
        scoreText.text = CurrentScore.ToString();
    }
}
