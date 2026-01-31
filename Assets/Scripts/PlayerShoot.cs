using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [Header("References")]
    public Transform firePoint;        // Merminin çýkacaðý nokta
    public GameObject bulletPrefab;    // Instantiate edeceðimiz prefab

    [Header("Tuning")]
    public float fireRate = 6f;        // saniyede 8 mermi gibi düþün (hold-to-fire)

    private float nextFireTime = 0f;        // bir sonraki ateþ edebileceðimiz zaman

    void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver) return;

        // 1) Mouse sol tuþ basýlý mý?
        bool isFiring = Mouse.current != null && Mouse.current.leftButton.isPressed;

        // 2) Basýlýysa ve cooldown dolduysa ateþ et
        if (isFiring && Time.time >= nextFireTime)
        {
            // 3) Bir sonraki ateþ zamanýný ayarla
            // fireRate = saniyedeki mermi sayýsý
            // 1/fireRate = iki mermi arasý süre
            nextFireTime = Time.time + (1f / fireRate);

            Shoot();
        }
    }

    void Shoot()
    {
        if (firePoint == null || bulletPrefab == null) return;

        // FirePoint pozisyonundan ve rotasyonundan prefab üretiriz.
        // Rotasyon çok kritik: merminin "forward" yönünü belirler.
        // GameObject Instantiate(GameObject original, Vector3 position, Quaternion rotation);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
