using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject blackScreen;

    [Space]
    public AudioSource mainBgm;
    public AudioSource gameOverBgm;

    private bool isOver;
    private bool gameOver;

    private void Start()
    {
        Time.timeScale = 1;
        FadeIn();
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
        mainBgm.Pause();
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        mainBgm.Play();
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
        gameOverBgm.Play();
        mainBgm.Stop();
        gameOverPanel.SetActive(true);
        isOver = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RePlay()
    {
        gameOver = false;
        isOver = false;
        
        mainBgm.Play();
        gameOverBgm.Stop();
        gameOverPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void FadeIn()
    {
        blackScreen.SetActive(true);
        blackScreen.GetComponent<Animator>().Play("fade in");
        Invoke("TurnOffBlackScreen", 2);
    }

    public void FadeOut()
    {
        blackScreen.SetActive(true);
        blackScreen.GetComponent<Animator>().Play("fade out");
    }

    void TurnOffBlackScreen()
    {
        blackScreen.SetActive(false);
    }
    
}
