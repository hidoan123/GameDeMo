using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnTime = 2f; // Thời gian giữa các lần sinh nhân vật
    public float spawnDelay = 2f; // Thời gian trễ trước lần sinh nhân vật đầu tiên
    public float bulletSpeed = 5f; // Tốc độ đạn
    public GameObject bulletPrefab; // Prefab của đạn
    private float timeElapsed = 0f; // Thời gian đã trôi qua
    private int somaybay = 0;
    public TMP_Text scoreText;
    public static int highScore;
    public static int score = 0;
    public List<GameObject> enemies = new List<GameObject>();
    private Dictionary<GameObject, float> shootTimers = new Dictionary<GameObject, float>();

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore"); 
    }
        void Update()
    {
        scoreText.text = "Score : " + score + "\nHighScore: " + highScore;
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= spawnTime && somaybay < 17)
        {
            SpawnEnemy();
            somaybay++;
            timeElapsed = 0f;
        }

        if (timeElapsed >= 14f)
        {
            spawnTime = 5f;
        }

        foreach (GameObject enemy in enemies)
        {
            if (enemy != null) // Nếu nhân vật không bị hủy
            {
                // Nếu chưa có biến đếm thời gian bắn đạn cho nhân vật này
                if (!shootTimers.ContainsKey(enemy))
                {
                    // Khởi tạo biến đếm thời gian bằng 0
                    shootTimers[enemy] = 0f;
                }

                // Tăng biến đếm thời gian bắn đạn của nhân vật lên mỗi khung hình
                shootTimers[enemy] += Time.deltaTime;

                // Nếu đã đến thời điểm bắn đạn tiếp theo
                if (shootTimers[enemy] >= 3f)
                {
                    ShootBullet(enemy); // Bắn đạn từ nhân vật
                    shootTimers[enemy] = 0f; // Reset biến đếm thời gian bắn đạn của nhân vật
                }
            }
        }
    }

    public void SpawnEnemy()
    {
            Vector2 spawnPosition = new Vector2(Random.Range(-10f, 10f), 5f);
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            enemy.transform.rotation = Quaternion.Euler(0f, 0f, 180f);// xoay 
            enemies.Add(enemy);
             
    }

    public void ShootBullet(GameObject enemy)
    {
        // Tạo đạn mới từ prefab
        GameObject bullet2 = Instantiate(bulletPrefab, enemy.transform.position, Quaternion.identity);

        // Thiết lập tốc độ đạn
        Rigidbody2D bulletRigidbody = bullet2.GetComponent<Rigidbody2D>();
        bulletRigidbody.velocity = new Vector2(0, -bulletSpeed);
        bullet2.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
    }

    public void ResetGame()
    {
        // Hủy tất cả các đối tượng sinh ra
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();

        // Reset các biến về giá trị ban đầu
        spawnTime = 2f;
        spawnDelay = 2f;
        bulletSpeed = 5f;
        timeElapsed = 0f;
        somaybay = 0;
        shootTimers.Clear();
        Start();
    }

}
