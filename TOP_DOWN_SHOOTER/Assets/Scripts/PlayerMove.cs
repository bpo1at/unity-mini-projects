using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [Header("Tuning")]
    public float moveSpeed = 6f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (GameManager.Instance != null && GameManager.Instance.IsGameOver)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }

        // WASD -> Vector2 (x: A/D, y: W/S)
        Vector2 input = Vector2.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed) input.y += 1;
            if (Keyboard.current.sKey.isPressed) input.y -= 1;
            if (Keyboard.current.dKey.isPressed) input.x += 1;
            if (Keyboard.current.aKey.isPressed) input.x -= 1;
        }

        // 2D input -> 3D hareket (x -> world x, y -> world z)
        Vector3 move = new Vector3(input.x, 0f, input.y);

        // çapraz giderken hýz artmasýn diye normalize
        if (move.sqrMagnitude > 1f) move.Normalize();

        // Rigidbody ile hareket (Unity 6: linearVelocity)
        Vector3 vel = move * moveSpeed;
        rb.linearVelocity = new Vector3(vel.x, 0f, vel.z);
    }
}
