using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    private bool isOver;
    private bool gameOver;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isOver)
            {
               PuaseGame();
            }
        }

        if (gameOver)
        {
            ActivateGameOverPanel();
        }
    }

    void PuaseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void GameOVer()
    {
        gameOver = true;
    }

    void ActivateGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        isOver = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RePlay()
    {
        gameOver = false;
        isOver = false;
        
        gameOverPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
}
