using UnityEngine;
using UnityEngine.SceneManagement; 

public class CreditsManager : MonoBehaviour
{
   
    public void RetourAuMenu()
    {
        
        SceneManager.LoadScene("Menu");
    }
}