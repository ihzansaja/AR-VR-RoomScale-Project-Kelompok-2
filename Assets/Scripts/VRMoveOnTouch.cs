using UnityEngine;

public class VRMoveOnTouch : MonoBehaviour
{
    public float speed = 1.5f;

    void Update()
    {
        bool isTouching = false;

        // Cek touch di Android
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began || t.phase == TouchPhase.Stationary || t.phase == TouchPhase.Moved)
            {
                isTouching = true;
            }
        }

        // Cek klik kiri pada PC (testing mode)
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }

        // Jika disentuh, maju
        if (isTouching)
        {
            Vector3 forward = new Vector3(transform.forward.x, 0, transform.forward.z);
            transform.position += forward * speed * Time.deltaTime;
        }
    }
}