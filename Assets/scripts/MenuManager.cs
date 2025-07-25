using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void Jouer()
    {
        SceneManager.LoadScene("Jeu");
    }

    
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    
    public void Quitter()
    {
        Debug.Log("Quitter le jeu");
        Application.Quit();
    }
}
