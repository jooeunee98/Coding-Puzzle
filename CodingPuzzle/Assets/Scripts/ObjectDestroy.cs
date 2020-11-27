using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour

{
    GameObject player;
    GameObject playBtn;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playBtn = GameObject.Find("playBtn");
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Destroy(player);
            GameObject Player1 = Instantiate(Resources.Load("prefab/player")) as GameObject;
            Player1.transform.position= new Vector3(0,68,50);
            Player1.transform.localScale -= new Vector3(15, 15, 15);
            player = GameObject.FindWithTag("clone");

            playBtn.GetComponent<pressPlay>().player = player;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
