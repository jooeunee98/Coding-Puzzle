using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBtns : MonoBehaviour
{
    GameObject codeCam = null;
    AudioSource audio;
    int comNum;
    GameObject array;
    // Start is called before the first frame update
    void Awake(){
        codeCam = GameObject.FindWithTag("codeCam");
    }
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
        GameObject.Find("player").transform.position= new Vector3(0,68,50);
        GameObject.Find("player").transform.localRotation= Quaternion.Euler(0, 90, 0);
        GameObject.Find("player").GetComponent<characterMotion>().isSuccess = false;
        for (int i = 0; i < comNum; i++)
        {
            array.GetComponent<commandList>().command[i] = 0;
        }
        GameObject.Find("forward").transform.localScale = new Vector3(1.5f,1,1);
        GameObject.Find("left").transform.localScale = new Vector3(1.5f,1,1);
        GameObject.Find("right").transform.localScale = new Vector3(1.5f,1,1);
        codeCam.transform.position = new Vector3(25,0,-37.3f);
        GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum=0;

        array.GetComponent<commandList>().index = 0;


    }

    public void returnBtn()
    {
        audio.Play();

        array.GetComponent<commandList>().index--;


        if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum > 0){
            GameObject.Find("commandArray").GetComponent<commandList>().command[GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum-1] = 0;
        } else if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum == 0){

            GameObject.Find("commandArray").GetComponent<commandList>().command[GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum] = 0;

        }

        if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum > 0){
            GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum--;
        }

        if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum == 0){
            codeCam.transform.position = new Vector3(25,0,-37.3f);
            
        } else{
            codeCam.transform.position += new Vector3(-24,0,0);


        }

    }
}
