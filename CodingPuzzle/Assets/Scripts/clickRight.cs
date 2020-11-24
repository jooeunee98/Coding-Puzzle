using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickRight : MonoBehaviour
{
    public GameObject array;
    int indexNo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickR()
    {
        indexNo = array.GetComponent<commandList>().index;
        array.GetComponent<commandList>().command[indexNo] = 2;
        array.GetComponent<commandList>().index++;
    }
}
