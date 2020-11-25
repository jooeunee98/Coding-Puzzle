using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localPosition.z > -525)
        {
            gameObject.transform.localPosition += new Vector3(0, 0, Time.deltaTime * -5);
        }
        else
            gameObject.transform.localPosition += new Vector3(0,0,525);
    }
}
