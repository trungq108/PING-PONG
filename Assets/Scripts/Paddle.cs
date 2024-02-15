using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ResetPositon()
    {
        rb.velocity = Vector2.zero;
        rb.position = new Vector2(transform.position.x, 0);
    }
}
