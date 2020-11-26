using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBlocksDisplay : MonoBehaviour
{
    public GameObject array2;
    public int comNum2 = 0;
    public int[] commandLoaded2;
    
    // Start is called before the first frame update
    void Start()
    {
        comNum2 = array2.GetComponent<commandList>().command.Length;
    }

    //Update is called once per frame
    void Update()
    {
        // 커맨드 리스트 업데이트
        for(int i=0; i<comNum2; i++){
            commandLoaded2[i] = array2.GetComponent<commandList>().command[i];
        }
        // 디스플레이
        for(int i=0; i<comNum2; i++){
            int x = 25;
            int y = 0;
            int z = 0;
            int s1 = 1;
            // 하나씩 읽어와서
            // 커맨드 해당 블록 이미지 -> 하이랄키에 추가
            if(commandLoaded2[i] == 1){
                GameObject forwardBlock = Instantiate(Resources.Load("prefab/forward"), new Vector3 (25,0,0), Quaternion.identity) as GameObject;
                forwardBlock.transform.parent = GameObject.FindWithTag("codeZoneCanvas").transform;                
                forwardBlock.transform.position = new Vector3(x,y,z);
                forwardBlock.transform.localScale = new Vector3(s1, s1, s1);
                Destroy(forwardBlock, 0.5f);

            }
        }
    }

}
