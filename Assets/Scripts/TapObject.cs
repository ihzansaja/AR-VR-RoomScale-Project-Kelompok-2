using UnityEngine;
using UnityEngine.SceneManagement;

public class TapObject : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    SceneManager.LoadScene("Scene_01");
                }
            }
        }
    }
}
