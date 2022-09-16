using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance = null;
    public bool gameStarted = false;

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

    void Update()
    {
        
    }

    public void StartGame()
    {
        gameStarted = true;
        mainMenu.SetActive(false);
    }
}
