using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private const int ballSpeed = 30;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LeftRacket")
        {
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * ballSpeed;
        }
        if (collision.gameObject.name == "RightRacket")
        {
            float y = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * ballSpeed;
        }
    }

    float hitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketHeight)
    {
        return (ballPosition.y - racketPosition.y) / racketHeight;
    }
}
