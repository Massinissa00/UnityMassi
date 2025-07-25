using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    public Text scoreText;
    public GameObject victoryPanel;
    private int totalItems;
    private int collectedItems;

    void Start()
    {
        totalItems = GameObject.FindGameObjectsWithTag("Collectable").Length;
        victoryPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            collectedItems++;
            scoreText.text = "Score: " + collectedItems + "/" + totalItems;

            if (collectedItems == totalItems)
            {
                Victory();
            }
        }
    }

    void Victory()
    {
        victoryPanel.SetActive(true);
        Time.timeScale = 0; // Arrête le jeu
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1; // Redémarre le jeu
        SceneManager.LoadScene("Menu");
    }
}
