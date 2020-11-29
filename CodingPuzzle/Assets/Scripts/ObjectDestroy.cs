using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour

{
    private Animator animator;

    GameObject player;
    GameObject playBtn;
    void Awake(){
        animator = GetComponent<Animator>();
    }
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
            Destroy(player.GetComponent<characterMotion>());
            player.transform.position= new Vector3(0,68,50);
            player.transform.localRotation= Quaternion.Euler(0, 90, 0);
                
            animator.SetBool("run", false);
            animator.SetBool("idle", true);
            animator.SetBool("dance", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
