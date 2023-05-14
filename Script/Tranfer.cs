using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tranfer : MonoBehaviour
{
    

    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 direction = Random.insideUnitCircle.normalized * speed;
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // Kiểm tra xem đối tượng va chạm có phải là một trong số các đối tượng nhân vật không
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {

    //        col.isTrigger = true;
    //    }
    //    // Đặt isTrigger của collider thành false để đạn trở thành collider thường
    //    col.isTrigger = false;
    //}
}
