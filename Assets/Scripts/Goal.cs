using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour 
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You won!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
