using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGoal : MonoBehaviour
{
    public float delaySec;
    public GameObject obj;
    int trigger = 0;
    GameObject sound;
    float timeSpan;

    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.Find("bgmPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger == 1)
        {
            if (delaySec > 0)
            {
                if (delaySec < 1)
                {
                    sound.GetComponent<AudioSource>().volume -= Time.deltaTime * 0.2f;
                }
                delaySec -= Time.deltaTime;
            }
            else
            {
                Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
                sound.GetComponent<AudioSource>().Stop();
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
