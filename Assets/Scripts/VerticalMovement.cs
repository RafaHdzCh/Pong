using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    private const int speed = 15;
    public string axis = "Vertical";

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * speed);
    }
}
