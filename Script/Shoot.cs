using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AudioClip shootSound;
    public AudioSource music;
    public GameObject bulletPrefab; // Prefab của viên đạn
    public Transform firePoint; // Vị trí bắn đạn
    public float bulletSpeed = 10f; // Tốc độ của viên đạn
    // Start is called before the first frame update
    void Start()
    {
        music = gameObject.AddComponent<AudioSource>();
        music.clip = shootSound;
        
    }

    // Update is called once per frame
    void Update()
    {
        // Kiểm tra xem người chơi đã bấm dấu cách chưa
        if (Input.GetKeyDown(KeyCode.Space) && Time.deltaTime != 0)
        {
            // Bắn đạn từ vị trí firePoint của máy bay
            Fire();
            music.Play();
        }
    }
    void Fire()
    {
        // Tạo một instance của viên đạn tại vị trí của firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Đặt tốc độ của viên đạn
        Vector2 velocity = new Vector2(0, bulletSpeed);
        bullet.GetComponent<Rigidbody2D>().velocity = velocity;
    }

}
