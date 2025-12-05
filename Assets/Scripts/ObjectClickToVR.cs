using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectClickToVR : MonoBehaviour
{
    public Camera arCamera;
    public string vrSceneName = "Scene_01";

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);

                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.collider != null && hit.collider.CompareTag("EnterVR"))
                    {
                        SceneManager.LoadScene(vrSceneName);
                    }
                }
            }
        }
    }
}
