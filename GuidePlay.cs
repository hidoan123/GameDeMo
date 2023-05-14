using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        hideGuidePlay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void hideGuidePlay()
    {
        gameObject.SetActive(false);
    }
}
