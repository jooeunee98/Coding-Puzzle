using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour

{
    GameObject player;
    GameObject playBtn;
    float startX, startY, startZ;
    public float rx, ry, rz;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playBtn = GameObject.Find("playBtn");
        startX = player.transform.position.x;
        startY = player.transform.position.y;
        startZ = player.transform.position.z;
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Destroy(player.GetComponent<characterMotion>());
            player.transform.position= new Vector3(startX,startY,startZ);
            player.transform.localRotation= Quaternion.Euler(rx, ry,rz);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
