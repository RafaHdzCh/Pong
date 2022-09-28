using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] AudioSource hit;
    public float ballSpeed = 30;
    private bool hasTheBallMoved = false;
    [SerializeField] Rigidbody2D ballRigidbody2D;


    private void Update()
    {
        if (GameManager.sharedInstance.gameStarted == true && hasTheBallMoved == false)
        {
            ballRigidbody2D.velocity = Vector2.right * ballSpeed;
            hasTheBallMoved = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit.Play();
        ballSpeed *= 1.008f;
        if (collision.gameObject.name == "LeftRacket")
        {
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            ballRigidbody2D.velocity = direction * ballSpeed;
        }
        else if (collision.gameObject.name == "RightRacket")
        {
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            ballRigidbody2D.velocity = direction * ballSpeed;
        }
    }

    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
