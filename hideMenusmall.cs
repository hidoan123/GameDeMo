using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hideMenusmall : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        HideMenuPanel();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void HideMenuPanel()
    {
        gameObject.SetActive(false);
    }

}
