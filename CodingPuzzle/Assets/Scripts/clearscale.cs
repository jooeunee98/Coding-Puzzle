using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearscale : MonoBehaviour
{

    public GameObject clear;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (i < 20)
        { clear.transform.localScale += new Vector3(0.3f, 0.2f, 0.2f);
            i++;
        }
    }
}
