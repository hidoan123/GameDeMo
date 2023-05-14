using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject closeGame;
    public Vector2 outsetOfposition;
    public AudioClip hitSound;
    private Collider2D col;
    public float speed = 5f; // Tốc độ di chuyển của nhân vật
    private Rigidbody2D rb; // Đối tượng Rigidbody để điều khiển vật lý của nhân vật
    private Vector2 moveDirection; // hướng di chuyển của nhân vaajt
    // Start is called before the first frame update
    void Start()
    {
        outsetOfposition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Lấy đầu vào của người chơi
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Tính toán hướng di chuyển của nhân vật
        moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Nếu người chơi đang di chuyển
        if (moveDirection != Vector2.zero)
        {
            // Di chuyển nhân vật
            rb.velocity = moveDirection * speed;
        }
        else
        {
            // Ngừng di chuyển khi không có đầu vào từ người chơi
            rb.velocity = Vector2.zero;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem đối tượng va chạm có phải là một trong số các đối tượng nhân vật không
        if (collision.gameObject.CompareTag("dandich") || collision.gameObject.CompareTag("DanRoi"))
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);// kêu lên 
            col.isTrigger = false;
            gameObject.SetActive(false);
            closeGame.SetActive(true);
        }
        // Đặt isTrigger của collider thành false để đạn trở thành collider thường
        col.isTrigger = true;
    }
    public void ResetPosition()
    {
        
        transform.position = outsetOfposition;
        //gameObject.SetActive(true);
    }
    
}
