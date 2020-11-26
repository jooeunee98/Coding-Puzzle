using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickRight : MonoBehaviour
{
    public GameObject array;
    int indexNo;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickR()
    {
        indexNo = array.GetComponent<commandList>().index;
        array.GetComponent<commandList>().command[indexNo] = 2;
        array.GetComponent<commandList>().index++;
        audio.Play();
    }
}
