using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void NewGame()
    {
        Score.CurrentScore = 0;
        SceneManager.LoadScene("MainLevel");
    }
}
