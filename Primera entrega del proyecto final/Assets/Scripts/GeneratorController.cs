using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float delaySpawn = 2f;
    public float intervalDelay = 2f;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",delaySpawn, intervalDelay);
    }

    private void SpawnEnemy()
    {
        int indexEnemy = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[indexEnemy], transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
