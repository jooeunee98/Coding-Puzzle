﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagescale : MonoBehaviour
{
    public GameObject stage;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (i < 10)
        {
            stage.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            i++;
        }
    }
}
