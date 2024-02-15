using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRb;
    public float ballSpeed = 100.0f;
    private void Awake()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        ResetPosition();
        AddStartingForce();

    }

    public void ResetPosition()
    {
        ballRb.velocity = Vector3.zero;
        ballRb.position = Vector3.zero;
    }
    public void AddStartingForce() 
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        ballRb.AddForce(direction * ballSpeed);
    }
    public void AddForce(Vector2 force)
    {
        ballRb.AddForce(force);
    }
}
