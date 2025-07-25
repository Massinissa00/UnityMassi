using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // La cible que la cam�ra doit suivre (votre personnage)
    public Vector3 offset = new Vector3(0, 2, -5); // Un d�calage pour positionner la cam�ra derri�re le personnage

    void LateUpdate()
    {
        // Mettre � jour la position de la cam�ra pour suivre la cible avec le d�calage
        transform.position = target.position + offset;

        // Optionnel : Faire en sorte que la cam�ra regarde toujours la cible
        transform.LookAt(target);
    }
}
