using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeBtns : MonoBehaviour
{
    GameObject codeCam = null;
    AudioSource audio;
    int comNum;
    GameObject array;
    GameObject player;

    float startX, startY, startZ;
    public float rx, ry, rz;

    // Start is called before the first frame update
    void Awake(){
        codeCam = GameObject.FindWithTag("codeCam");
    }
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        array = GameObject.Find("commandArray");
        comNum = array.GetComponent<commandList>().command.Length;

        player = GameObject.Find("player");
        startX = player.transform.position.x;
        startY = player.transform.position.y;
        startZ = player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetBtn()
    {
        audio.Play();
        //Destroy(player.GetComponent<characterMotion>());
        player.transform.position = new Vector3(startX, startY, startZ);
        player.transform.localRotation = Quaternion.Euler(rx, ry, rz);
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
