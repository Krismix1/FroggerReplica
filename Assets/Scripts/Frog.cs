using UnityEngine;

public class Frog : MonoBehaviour 
{

    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb2D.MovePosition(rb2D.position + Vector2.up);
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb2D.MovePosition(rb2D.position + Vector2.down);
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb2D.MovePosition(rb2D.position + Vector2.left);
        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb2D.MovePosition(rb2D.position + Vector2.right);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Car"))
        {
            rb2D.MovePosition(new Vector2(0f, -4f));
        }
    }
}
