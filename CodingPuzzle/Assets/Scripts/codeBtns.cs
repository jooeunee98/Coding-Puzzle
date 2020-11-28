using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBtns : MonoBehaviour
{
    AudioSource audio;
    int comNum;
    GameObject array;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        array = GameObject.Find("commandArray");
        comNum = array.GetComponent<commandList>().command.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBtn()
    {
        audio.Play();
        for (int i = 0; i < comNum; i++)
        {
            array.GetComponent<commandList>().command[i] = 0;
        }
    }

    public void returnBtn()
    {
        audio.Play();
    }
}
