using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnMotion : MonoBehaviour
{
    public float delaySec;
    public float speed;
    float timeSpan;
    int trigger = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (delaySec > 0)
        {
            delaySec -= Time.deltaTime;
        }
        else
        {
            if (trigger == 1)
            {
                gameObject.transform.localPosition += new Vector3(0, Time.deltaTime * speed, 0);
                if (gameObject.transform.localPosition.y > 5)
                    trigger = 0;
            }
            else if (trigger == 0)
            {
                gameObject.transform.localPosition -= new Vector3(0, Time.deltaTime * speed, 0);
                if (gameObject.transform.localPosition.y < -5)
                    trigger = 1;
            }
        }
    }
}
