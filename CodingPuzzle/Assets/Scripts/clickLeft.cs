using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickLeft : MonoBehaviour
{
    public GameObject array;
    int indexNo;
    int forIndex;
    GameObject codeCam = null;
    
    void Awake(){
        codeCam = GameObject.FindWithTag("codeCam");
    }
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        forIndex = GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum;
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickL()
    {
        if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum > 0 && GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum < GameObject.Find("commandArray").GetComponent<commandList>().command.Length)
            codeCam.transform.position += new Vector3(24,0,0);
        if(GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum == GameObject.Find("commandArray").GetComponent<commandList>().command.Length){
            GameObject.Find("forward").transform.localScale = new Vector3(0,0,0);
            GameObject.Find("left").transform.localScale = new Vector3(0,0,0);
            GameObject.Find("right").transform.localScale = new Vector3(0,0,0);
        }
        GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum++;
        forIndex = GameObject.Find("forIndexing").GetComponent<forIndexing>().indexNum;
        
        indexNo = array.GetComponent<commandList>().index;
        array.GetComponent<commandList>().command[indexNo] = 3;
        array.GetComponent<commandList>().index++;
        audio.Play();
    }
}
