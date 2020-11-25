using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commandPop : MonoBehaviour
{
    public float delaySec;
    float timespan;
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
            if (timespan < 0.75)
            {
                gameObject.transform.localPosition += new Vector3(0, Time.deltaTime * 173, 0);
                timespan += Time.deltaTime;
            }
            else if (timespan < 1)
            {
                gameObject.transform.localPosition += new Vector3(0, Time.deltaTime * (-40), 0);
                timespan += Time.deltaTime;
            }
        }
    }
}
