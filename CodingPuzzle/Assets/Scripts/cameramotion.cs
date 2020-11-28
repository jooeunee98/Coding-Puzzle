using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramotion : MonoBehaviour
{
    public float cam1px, cam1py, cam1pz, cam1rx, cam1ry, cam1rz;
    public float cam2px, cam2py, cam2pz, cam2rx, cam2ry, cam2rz;
    int camNo = 1;
    public GameObject camera;
    AudioSource audio;
    Quaternion test;
    public float delaySec;
    float timeSpan;

    // Start is called before the first frame update
    void Start()
    {
        cam1px = camera.transform.position.x;
        cam1py = camera.transform.position.y;
        cam1pz = camera.transform.position.z;

        audio = gameObject.GetComponent<AudioSource>();
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
            if(timeSpan < 2)
            {
                gameObject.transform.localPosition += new Vector3(Time.deltaTime * 60, 0, 0);
            }
            timeSpan += Time.deltaTime;
        }

        if(camNo==1)
        {
            camera.transform.position = new Vector3(cam1px, cam1py, cam1pz);
            camera.transform.localRotation = Quaternion.Euler(cam1rx, cam1ry, cam1rz);
        }
        else if(camNo==2)
        {
            camera.transform.position = new Vector3(cam2px, cam2py, cam2pz);
            camera.transform.localRotation = Quaternion.Euler(cam2rx, cam2ry, cam2rz);
        }
    }
    public void pressCamBtn()
    {
        if(camNo==1)
        {
            camNo = 2;
        }
        else if(camNo==2)
        {
            camNo = 1;
        }

        audio.Play();
    }
}
