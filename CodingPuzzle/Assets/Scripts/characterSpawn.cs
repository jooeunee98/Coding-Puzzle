using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSpawn : MonoBehaviour
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
            if (timespan <= 0.5)
            {
                gameObject.transform.localScale += new Vector3(Time.deltaTime * 30, Time.deltaTime * 30, Time.deltaTime * 30);
            }
            timespan += Time.deltaTime;
        }
    }
}
