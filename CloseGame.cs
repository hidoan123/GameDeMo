using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        HideCloseGame();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + GameController.score;

    }
    public void HideCloseGame()
    {
        gameObject.SetActive(false);
    }
}
