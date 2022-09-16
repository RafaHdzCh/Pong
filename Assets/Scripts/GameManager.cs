using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance = null;
    public bool gameStarted = false;

    [SerializeField] GameObject logo;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject background;

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

    void Update()
    {
        
    }

    public void StartGame()
    {
        gameStarted = true;
        logo.SetActive(false);
        playButton.SetActive(false);
        background.SetActive(false);
    }
}
