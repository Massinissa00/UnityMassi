using UnityEngine;
using UnityEngine.SceneManagement; // N'oublie pas cette ligne pour la gestion des sc�nes

public class CreditsManager : MonoBehaviour
{
    // Fonction appel�e quand on clique sur le bouton "Retour au Menu"
    public void RetourAuMenu()
    {
        // Charge la sc�ne appel�e "Menu"
        SceneManager.LoadScene("Menu");
    }
}