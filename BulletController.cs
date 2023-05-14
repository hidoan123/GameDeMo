using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speedtime;
    public float speed = 10f; // Tốc độ của đạn
    public float damage = 10f; // Sát thương của đạn
    private Collider2D col;

    private void Update()
    {
        // Di chuyển đạn xuống dưới
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        
    }
    void Start()
    {
       
        col = GetComponent<Collider2D>();

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    // Kiểm tra xem đối tượng va chạm có phải là một trong số các đối tượng nhân vật không
    //    if (collision.gameObject.CompareTag("MayBay"))
    //    {
    //        // Xóa đối tượng nhân vật
    //        Destroy(collision.gameObject);
    //    }

    //    // Xóa đối tượng viên đạn
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem đối tượng va chạm có phải là một trong số các đối tượng nhân vật không
        if (collision.gameObject.CompareTag("MayBay"))
        {
           
            col.isTrigger = false;
        }
        // Đặt isTrigger của collider thành false để đạn trở thành collider thường
        col.isTrigger = true;
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
