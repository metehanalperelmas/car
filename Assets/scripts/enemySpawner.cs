using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject[] enemycarPrefab;
    public float spawnTime = 1f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(enemycarPrefab[Random.Range(0,2)], new Vector2(Random.Range(-1.8f, 1.8f), transform.position.y), transform.rotation);
            timer = spawnTime;

        }
        
    }
}
