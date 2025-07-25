using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Cette m�thode charge la sc�ne de jeu
    public void Jouer()
    {
        SceneManager.LoadScene("Jeu");
    }

    // Cette m�thode charge la sc�ne des cr�dits
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    // Cette m�thode quitte l'application
    public void Quitter()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();
    }
}
