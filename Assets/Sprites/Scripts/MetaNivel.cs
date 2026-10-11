using UnityEngine;

public class MetaNivel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Player"))
        {
            Debug.Log("¡Nivel completado!");
        }
    }
}
