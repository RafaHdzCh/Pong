using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoalZone : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score;

    private void Awake()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("GOL");
            score++;
            scoreText.text = score.ToString();
        }
    }
}
