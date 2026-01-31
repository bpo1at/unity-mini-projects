using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
