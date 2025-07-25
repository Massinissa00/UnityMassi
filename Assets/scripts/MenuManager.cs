using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Cette méthode charge la scène de jeu
    public void Jouer()
    {
        SceneManager.LoadScene("Jeu");
    }

    // Cette méthode charge la scène des crédits
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    // Cette méthode quitte l'application
    public void Quitter()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();
    }
}
