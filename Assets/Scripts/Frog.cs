using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour 
{
    public Transform leftWall;
    public Transform rightWall;
    public Transform bottomWall;
    public Rigidbody2D rb2D;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb2D.MovePosition(rb2D.position + Vector2.up);
        }else if (Input.GetKeyDown(KeyCode.DownArrow) &&
            rb2D.position.y + Vector2.down.y >= bottomWall.position.y)
        {
            rb2D.MovePosition(rb2D.position + Vector2.down);
        }else if (Input.GetKeyDown(KeyCode.LeftArrow) && 
            rb2D.position.x + Vector2.left.x >= leftWall.position.x)
        {
            rb2D.MovePosition(rb2D.position + Vector2.left);
        }else if (Input.GetKeyDown(KeyCode.RightArrow) && 
            rb2D.position.x + Vector2.right.x <= rightWall.position.x)
        {
            rb2D.MovePosition(rb2D.position + Vector2.right);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Car"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
