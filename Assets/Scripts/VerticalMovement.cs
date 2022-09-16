using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    private const int speed = 15;
    public string axis = "Vertical";
    [SerializeField] Rigidbody2D racketRigidbody;

    void FixedUpdate()
    {
        if(GameManager.sharedInstance.gameStarted == true)
        {
            float v = Input.GetAxisRaw(axis);
            racketRigidbody.velocity = new Vector2(0, v * speed);
        }
    }
}
