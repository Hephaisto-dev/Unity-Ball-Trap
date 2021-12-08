using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public GameObject BirdPrefab;
    public Transform cam;

    public 
    public float spawnRange = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFrisbee()
    {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y = cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
            float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
            Vector3 spawnPos = new Vector3(x, y, z);
            InstantiateBirdPrefab, spawnPos, Quaternion.identity);
        }
    }
}
