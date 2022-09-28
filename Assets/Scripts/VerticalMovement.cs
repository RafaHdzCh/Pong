using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField] GameObject backToMainMenuText;
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
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            backToMainMenuText.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
