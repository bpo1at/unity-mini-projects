using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("References")]
    public Transform target;  // Player

    [Header("Tuning")]
    public float moveSpeed = 3f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        dir.y = 0f; // sadece yerde yürüsün

        if (dir.sqrMagnitude < 0.01f) return;

        Vector3 vel = dir.normalized * moveSpeed;

        if (rb != null)
        {
            // Unity 6+
            rb.linearVelocity = new Vector3(vel.x, 0f, vel.z);
        }
        else
        {
            transform.position += vel * Time.fixedDeltaTime;
        }

        // Yönünü player'a döndür (isteðe baðlý ama iyi görünür)
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
