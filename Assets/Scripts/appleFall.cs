using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleFall : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public float spawnInterval = 1.0f;

    
    public float minX = -10f; 
    public float maxX = 10f;  
    public float spawnY = 10f; 

    private void Start()
    {
        
        InvokeRepeating("SpawnFallingObject", 0f, spawnInterval);
    }

    void SpawnFallingObject()
    {
        
        float randomX = Random.Range(minX, maxX);

        
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0f);

        
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
    }
}
