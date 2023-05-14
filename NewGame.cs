using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{
    public DanRoi danRoi;
    public PlayerController myObject;
    public GameController game;
    public GameObject menuSmallPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }
    public void RestartGame()
    {

        // Đặt lại các biến trong game
        menuSmallPanel.SetActive(false);
        GameController.score = 0;
        game.ResetGame();
        myObject.ResetPosition();
        danRoi.ReSetDanRoi();
        Time.timeScale = 1.0f;

    }
}
