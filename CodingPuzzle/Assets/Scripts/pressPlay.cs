using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressPlay : MonoBehaviour
{
    public characterMotion motion;
    public GameObject player;
    GameObject codeCam = null;

    void Awake(){
        codeCam = GameObject.FindWithTag("codeCam");
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // waitTime : 카메라 체류 시간
    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        GameObject.Find("forward").transform.localScale = new Vector3(1.5f,1,1);
        GameObject.Find("left").transform.localScale = new Vector3(1.5f,1,1);
        GameObject.Find("right").transform.localScale = new Vector3(1.5f,1,1);
        codeCam.transform.position = new Vector3(25,0,-37.3f);
        
        player.AddComponent<characterMotion>();
    }
}
