using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressPlay : MonoBehaviour
{
    public characterMotion motion;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        player.AddComponent<characterMotion>();
    }
}
