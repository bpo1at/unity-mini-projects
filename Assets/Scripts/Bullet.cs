using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Tuning")]
    public float speed = 20f;     // mermi hýzý
    public float lifeTime = 1.5f;   // kaç saniye sonra yok olsun

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // 1) Sahne dolmasýn diye belirli süre sonra mermiyi sil
        Destroy(gameObject, lifeTime);

        // 2) Mermiyi kendi forward yönünde fýrlat
        // transform.forward = merminin mavi oku (Z yönü)
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed; // Unity 6+
            // Eski sürüm olursa: rb.velocity = transform.forward * speed;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Player'a deðerse yok say (push/kayma hissini azaltýr)
        if (other.CompareTag("Player"))
            return;

        // Enemy'ye çarparsa ikisini de yok et
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            return;
        }

        // Ýstersen duvara/zemine çarpýnca da yok olsun
        // Destroy(gameObject);
    }
}
