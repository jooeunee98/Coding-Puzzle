using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGoal : MonoBehaviour
{
    public float delaySec;
    public GameObject obj;
    int trigger = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == 1)
        {
            if (delaySec > 0)
            {
                delaySec -= Time.deltaTime;
            }
            else
            {
                Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        trigger = 1;
    }
}
