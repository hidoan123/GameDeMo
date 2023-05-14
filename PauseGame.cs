using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool checkDungGame = false;
    public GameObject menuSmallPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0;
        menuSmallPanel.SetActive(true);
    }
    
}
