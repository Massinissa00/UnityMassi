using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // La cible que la caméra doit suivre (votre personnage)
    public Vector3 offset = new Vector3(0, 2, -5); // Un décalage pour positionner la caméra derrière le personnage

    void LateUpdate()
    {
        // Mettre à jour la position de la caméra pour suivre la cible avec le décalage
        transform.position = target.position + offset;

        // Optionnel : Faire en sorte que la caméra regarde toujours la cible
        transform.LookAt(target);
    }
}
