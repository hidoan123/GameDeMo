using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        AudioPause();
    }
    void AudioPause()
    {
        if(Time.deltaTime == 0)
        {
            AudioListener.pause = true;
        }
        else
        {
            AudioListener.pause = false;

        }
    }
}
