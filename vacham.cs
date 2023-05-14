using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacham : MonoBehaviour
{
    public AudioClip hitSound;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra xem đối tượng va chạm có phải là một trong số các đối tượng nhân vật không
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Xóa đối tượng nhân vật
            AudioSource.PlayClipAtPoint(hitSound, transform.position);// kêu lên 
            Destroy(collision.gameObject);
           
            GameController.score++;
            
            if (GameController.score > GameController.highScore)
            {
                GameController.highScore = GameController.score;
                PlayerPrefs.SetInt("HighScore", GameController.score);
            }
        }

        // Xóa đối tượng viên đạn
        Destroy(gameObject);
    }
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
