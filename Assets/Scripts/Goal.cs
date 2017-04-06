using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour 
{
    public Score score;
    public int pointsToGive = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Score.CurrentScore += pointsToGive;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
