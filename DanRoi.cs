using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanRoi : MonoBehaviour
{
  
    public GameObject[] enemyPrefabs;
    public float spawnTime = 1.5f; // Thời gian giữa các lần sinh nhân vật
    public float spawnDelay = 1.5f; // Thời gian trễ trước lần sinh nhân vật đầu tiên
    public List<GameObject> enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-5f, 5f), 10f);
        GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        enemies.Add(enemy);

    }

    public void ReSetDanRoi()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
        //reset ve gia tri ban dau
        spawnTime = 1.5f; // Thời gian giữa các lần sinh nhân vật
        spawnDelay = 1.5f; // Thời gian trễ trước lần sinh nhân vật đầu tiên
        Start();
    }
}
