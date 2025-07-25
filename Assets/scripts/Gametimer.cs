using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public Text timerText;
    public float totalTime = 60f; // Temps total en secondes
    private float currentTime;
    public GameObject gameOverPanel;

    void Start()
    {
        currentTime = totalTime;
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay(currentTime);
        }
        else
        {
            currentTime = 0;
            GameOver();
        }
    }

    void UpdateTimerDisplay(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        timerText.text = "Time: 00:00";
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // Arrête le jeu
    }

    public void Retry()
    {
        Time.timeScale = 1; // Redémarre le jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
