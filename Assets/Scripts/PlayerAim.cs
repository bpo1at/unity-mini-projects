using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour
{
    public Camera cam;
    public LayerMask groundMask;
    public float rotateSpeed = 20f;

    void Reset()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (cam == null) return;

        Vector2 mousePos = Mouse.current.position.ReadValue();
        Ray ray = cam.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out RaycastHit hit, 200f, groundMask))
        {
            Vector3 target = hit.point;
            target.y = transform.position.y;

            Vector3 dir = target - transform.position;
            if (dir.sqrMagnitude < 0.0001f) return;

            Quaternion targetRot = Quaternion.LookRotation(dir, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        }
    }
}
