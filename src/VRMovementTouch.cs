using UnityEngine;

public class VRMovementTouchSmooth : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float smooth = 5f;

    private bool isTouching = false;
    private Vector3 targetDirection;

    void Update()
    {
        // Deteksi sentuhan layar
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
                isTouching = true;
            if (t.phase == TouchPhase.Ended)
                isTouching = false;
        }

        // Jika menyentuh layar → maju
        if (isTouching)
        {
            targetDirection = transform.forward;
        }
        else
        {
            targetDirection = Vector3.zero;
        }

        // Gerakan dengan smoothing
        Vector3 smoothMove = Vector3.Lerp(Vector3.zero, targetDirection, Time.deltaTime * smooth);
        transform.position += smoothMove * moveSpeed * Time.deltaTime;
    }
}