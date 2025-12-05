using UnityEngine;

public class VERxplorer : MonoBehaviour
{
    public float lookSensitivity = 0.15f;
    public float moveSpeed = 2.3f;

    private float verticalRotation = 0f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            // === ROTASI KAMERA (gerakan halus & tidak bergetar) ===
            if (t.phase == TouchPhase.Moved)
            {
                float rotX = t.deltaPosition.x * lookSensitivity;
                float rotY = t.deltaPosition.y * lookSensitivity;

                // Rotasi horizontal (badan)
                transform.Rotate(0f, rotX, 0f);

                // Rotasi vertikal (kamera)
                verticalRotation -= rotY;
                verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f);
                Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
            }

            // === JALAN HANYA SAAT TOUCH STATIONARY (jari diam) ===
            if (t.phase == TouchPhase.Stationary)
            {
                Vector3 move = transform.forward * moveSpeed * Time.deltaTime;
                controller.Move(move);
            }
        }
    }
}
