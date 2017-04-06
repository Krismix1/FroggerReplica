using UnityEngine;

public class Car : MonoBehaviour 
{
    public float minimumSpeed = 8f;
    public float maximumSpeed = 12f;

    private float speed = 2f;
    private Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        speed = Random.Range(minimumSpeed, maximumSpeed);
    }

    private void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb2D.MovePosition(rb2D.position + forward * Time.fixedDeltaTime * speed);
    }
}
