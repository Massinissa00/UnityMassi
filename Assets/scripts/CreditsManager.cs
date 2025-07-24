using UnityEngine;
using UnityEngine.SceneManagement; // N'oublie pas cette ligne pour la gestion des scènes

public class CreditsManager : MonoBehaviour
{
    // Fonction appelée quand on clique sur le bouton "Retour au Menu"
    public void RetourAuMenu()
    {
        // Charge la scène appelée "Menu"
        SceneManager.LoadScene("Menu");
    }
}