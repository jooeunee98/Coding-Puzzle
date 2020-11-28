using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlocksDisplay : MonoBehaviour
{
    public GameObject array2;
    public GameObject[] Blocks;
    public GameObject[] Arrows;
    public int comNum2 = 0;
    public int[] commandLoaded2;
    public int blockIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        comNum2 = array2.GetComponent<commandList>().command.Length;
        commandLoaded2 = new int[comNum2];
        for (int i = 0; i < comNum2; i++)
        {
            commandLoaded2[i] = array2.GetComponent<commandList>().command[i];
        }
        Blocks = new GameObject[comNum2];
        Arrows = new GameObject[comNum2];
    }

    //Update is called once per frame
    void Update()
    {
        int x = 524;
        int y = 154;
        int z = 0;
        float s1 = 0.15f;
        float s2 = 0.03f;
        // 커맨드 리스트 업데이트
        for(int i=0; i<comNum2; i++){
            commandLoaded2[i] = array2.GetComponent<commandList>().command[i];
        }
        // 디스플레이
        blockIndex = 0;

        for(int i=0; i<comNum2; i++){
            // 하나씩 읽어와서
            // 커맨드 해당 블록 이미지 -> 하이랄키에 추가
            if(commandLoaded2[i] == 1){
                
                Blocks[i] = Instantiate(Resources.Load("prefab/forward"), new Vector3(x,y,z), Quaternion.identity) as GameObject;
                Blocks[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Blocks[i].transform.position = new Vector3(x,y,z);
                Blocks[i].transform.localScale = new Vector3(s1,s1,s1);
                x -= 4;
                Arrows[i] = Instantiate(Resources.Load("prefab/arrowRealReal"), new Vector3(x,y,z), Quaternion.identity) as GameObject;
                Arrows[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Arrows[i].transform.localScale = new Vector3(s2,s2,s2);
                Arrows[i].transform.localEulerAngles += new Vector3(0,180,0); 
                x -= 4;
            } else if(commandLoaded2[i] == 2){
                Blocks[i] = Instantiate(Resources.Load("prefab/right"), new Vector3(x,y,z), Quaternion.identity) as GameObject;
                Blocks[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Blocks[i].transform.position = new Vector3(x,y,z);
                Blocks[i].transform.localScale = new Vector3(s1,s1,s1);
                Blocks[i].transform.localEulerAngles += new Vector3(0,180,0); 
                x -= 4;
                Arrows[i] = Instantiate(Resources.Load("prefab/arrowRealReal"), new Vector3(x,y,z), Quaternion.identity) as GameObject;
                Arrows[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Arrows[i].transform.localScale = new Vector3(s2,s2,s2);
                Arrows[i].transform.localEulerAngles += new Vector3(0,180,0); 
                x -= 4;
            } else if(commandLoaded2[i] == 3){
                Blocks[i] = Instantiate(Resources.Load("prefab/left"), new Vector3(x,y,z), Quaternion.identity) as GameObject;
                Blocks[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Blocks[i].transform.position = new Vector3(x,y,z);
                Blocks[i].transform.localScale = new Vector3(s1,s1,s1);
                Blocks[i].transform.localEulerAngles += new Vector3(0,180,0);
                x -= 4;

                Arrows[i] = Instantiate(Resources.Load("prefab/arrowRealReal"), new Vector3 (x,y,z), Quaternion.identity) as GameObject;
                Arrows[i].transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;
                Arrows[i].transform.localScale = new Vector3(s2,s2,s2);
                Arrows[i].transform.localEulerAngles += new Vector3(0,180,0);  
                x -= 4;
            } 

            
            blockIndex++;

        }

        for(int i=0; i<comNum2; i++){
            Destroy(Blocks[i], 0.05f);
            Destroy(Arrows[i], 0.05f);
        }
    }

}
