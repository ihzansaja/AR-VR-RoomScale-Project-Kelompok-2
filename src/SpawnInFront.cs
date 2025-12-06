using UnityEngine;

public class SpawnInFront : MonoBehaviour
{
    public GameObject objectToSpawn;   // Prefab bangunan kamu
    public Camera arCamera;            // AR Camera

    void Start()
    {
        // Posisi 1 meter di depan kamera
        Vector3 spawnPos = arCamera.transform.position + arCamera.transform.forward * 1f;

        // Rotasi agar objek menghadap kamera
        Quaternion spawnRot = Quaternion.LookRotation(arCamera.transform.forward);

        Instantiate(objectToSpawn, spawnPos, spawnRot);
    }
}
