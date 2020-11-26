using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickLeft : MonoBehaviour
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

    public void clickL()
    {
        indexNo = array.GetComponent<commandList>().index;
        array.GetComponent<commandList>().command[indexNo] = 3;
        array.GetComponent<commandList>().index++;
        audio.Play();
    }
}
