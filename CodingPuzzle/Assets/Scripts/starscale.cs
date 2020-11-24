using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starscale : MonoBehaviour
{

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    int i = 0;
    float timespan = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timespan >= 0)
        {
            timespan -= Time.deltaTime;
            return;
        }
        else
        {
            if (0 < i && i < 25)
            {
                star1.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); // 짠나타나여
            }
            if (12 < i && i <= 37)
            {
                star2.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); // 짠나타나여
            }
            if (25 < i && i <= 50)
            {
                star3.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); // 짠나타나여
            }
            i++;
        }
    }
}
