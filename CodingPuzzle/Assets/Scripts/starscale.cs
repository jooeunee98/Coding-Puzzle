using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starscale : MonoBehaviour
{
    AudioSource audio;
    public float delaySec = 1.0f;
    float timeSpan;
    int trigger = 1;
    float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(delaySec >= 0)
        {
            delaySec -= Time.deltaTime;
            return;
        }
        else
        {
            if (timeSpan > 0 && timeSpan < 0.5)
            {
                gameObject.transform.localScale += new Vector3((Time.deltaTime * speed), (Time.deltaTime * speed), (Time.deltaTime * speed)); // 짠나타나여
            }
            if (trigger == 1)
            {
                audio.Play();
                trigger = 0;
            }
            timeSpan += Time.deltaTime;
        }
    }
}
