using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code_zone_motion : MonoBehaviour
{
    float timespan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timespan <= 1.5)
        {
            gameObject.transform.localPosition += new Vector3(0, Time.deltaTime * (-240), 0);
        }
        else if (timespan <= 2)
        {
            gameObject.transform.localPosition += new Vector3(0, Time.deltaTime * (20), 0);
        }
        timespan += Time.deltaTime;
    }
}
