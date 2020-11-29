using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    float maxY, minY;
    public float gap, speed = 10;
    int trigger = 1;
    GameObject obj;
    void Start()
    {
        maxY = gameObject.transform.position.y + gap;
        minY = gameObject.transform.position.y - gap;
        obj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == 1)
        {
            obj.transform.localPosition += new Vector3(0, Time.deltaTime * speed, 0);
        }
        else if (trigger == 2)
        {

            obj.transform.localPosition -= new Vector3(0, Time.deltaTime * speed, 0);
        }

        if (gameObject.transform.position.y > maxY)
        {
            trigger = 2;
        }
        else if (gameObject.transform.position.y < minY)
        {
            trigger = 1;
        }
    }
}
