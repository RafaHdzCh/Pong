using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance = null;
    public bool gameStarted = false;
    private Vector2 nextDirection;

    [SerializeField] GameObject ball;
    [SerializeField] Ball ballScript;
    [SerializeField] Rigidbody2D ballRigidbody2D;
    [SerializeField] GameObject mainMenu;

    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void StartGame()
    {
        gameStarted = true;
        mainMenu.SetActive(false);
    }

    public void GoalScored()
    {
        ball.transform.position = Vector3.zero;
        nextDirection = new Vector2(-ballRigidbody2D.velocity.x, 0);
        ballRigidbody2D.velocity = Vector3.zero;

        Invoke(nameof(LaunchBall), 2f);
    }

    private void LaunchBall()
    {
        ballRigidbody2D.velocity = nextDirection.normalized * ballScript.ballSpeed;
    }
}
