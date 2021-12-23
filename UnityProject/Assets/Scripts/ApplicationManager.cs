using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public GameObject BirdPrefab;
    public Transform cam;
    private bool playing = false;
    public GameObject button;

    public float spawnRange = 3f;
    private int count = 0;
    public int _birdCount;
    private int multiplier = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBird", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (_birdCount > 40)
        {
            loose();
            foreach (Object go in GameObject.FindGameObjectsWithTag("Bird"))
            {
                GameObject.Destroy(go);
            }
        }
    }

    public void SpawnBird()
    {
        if (playing)
        {
            for (int i = 0; i < multiplier; i++){
                float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
                float y = cam.transform.position.y + Random.Range(-spawnRange, spawnRange);
                float z = cam.transform.position.z + Random.Range(-spawnRange, spawnRange);
                Vector3 spawnPos = new Vector3(x, y, z);
                Instantiate(BirdPrefab, spawnPos, Quaternion.identity);
                _birdCount++;
            }
            multiplier++;
        }
    }

    public void setPlaying()
    {
        playing = true;
        _birdCount = 0;
    }

    private void loose()
    {
        playing = false;
        button.SetActive(true);
    }
}
