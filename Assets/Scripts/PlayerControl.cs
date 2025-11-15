using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float moveX;
    private float moveY;
    private Rigidbody2D rb;
    public float speed = 3.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(moveX * speed, moveY * speed);

        Debug.Log(rb.linearVelocity);
    }
}
