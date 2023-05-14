using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    public GameObject menuSmallPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnContinuesClick()
    {
        Time.timeScale = 1;
        menuSmallPanel.SetActive(false);
    }
}
