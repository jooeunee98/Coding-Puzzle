using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmFadeIn : MonoBehaviour
{
    float timeSpan;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSpan < 2)
        {
            gameObject.GetComponent<AudioSource>().volume += Time.deltaTime * 0.1f;
        }
        timeSpan += Time.deltaTime;
    }
}
