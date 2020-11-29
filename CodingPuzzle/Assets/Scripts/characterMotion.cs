using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMotion : MonoBehaviour
{
    private Animator animator;
    public GameObject array;
    public int comNum = 0;
    public static int arraySize = 1;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        
    }
    public float delay2 = 1.0f;
    int[] commandLoaded;
    private IEnumerator coroutine;
    bool go_forward = false;
    bool turn_right = false;
    bool turn_left = false;
    int turnDegree = 0;
    bool isLast = false;
    public bool isSuccess = false;

    // Start is called before the first frame update
    void Start()
    {
        array = GameObject.Find("commandArray");
        comNum = array.GetComponent<commandList>().command.Length;
        commandLoaded = new int[comNum];
        for (int i = 0; i < comNum; i++)
        {
            commandLoaded[i] = array.GetComponent<commandList>().command[i];
        }
        coroutine = readCommand(1.0f);
        StartCoroutine(coroutine);
        //Debug.Log("Here1");
        

    }
    public IEnumerator readCommand(float waitTime)
    {                               
    // waitTime : 카메라 체류 시간
    // + 카메라 이동을 위한 시간까지 waitTime에 더해놓을것!
        for (int i = 0; i < commandLoaded.Length; i++)
        {
            if(commandLoaded[i+1] == 0){
                isLast = true;
            }
            if (commandLoaded[i] == 1)
            {
                
                animator.SetBool("run", true);
                animator.SetBool("idle", false);
                waitTime = 2.0f;
                delay2 = 1.0f;
                // 시간지연 1초 지나면 카메라 이동 1초

                go_forward = true;
                turn_left = false;
                turn_right = false;

                yield return new WaitForSeconds(waitTime);
            }
            else if (commandLoaded[i] == 2)
            {
                animator.SetBool("run", true);
                animator.SetBool("idle", false);
                waitTime = 2.5f;
                delay2 = 1.5f;

                go_forward = false;
                turn_right = true;
                turn_left = false;

                yield return new WaitForSeconds(waitTime);

            }
            else if (commandLoaded[i] == 3)
            {
                animator.SetBool("run", true);
                animator.SetBool("idle", false);
                waitTime = 2.5f;
                delay2 = 1.5f;

                go_forward = false;
                turn_left = true;
                turn_right = false;

                yield return new WaitForSeconds(waitTime);

            }
            else if(commandLoaded[i] == 0 || i == commandLoaded.Length - 1)
            {
                go_forward = false;
                turn_left = false;
                turn_right = false;
                if(GameObject.Find("player").GetComponent<characterMotion>().isSuccess == false){
                    animator.SetBool("run", false);
                    animator.SetBool("idle", true);
                } else {
                    animator.SetBool("run", false);
                    animator.SetBool("idle", false);
                    animator.SetBool("dance", true);
                }
                    
                
                StopCoroutine(coroutine);
            } 

        
        }
    }

    // Update is called once per frame
    void Update()
    {
        comNum = array.GetComponent<commandList>().command.Length;


        for (int i = 0; i < comNum; i++)
        {
            commandLoaded[i] = array.GetComponent<commandList>().command[i];
        }
        if (go_forward == true)
        {
            delay2 -= Time.deltaTime;
            transform.Translate(this.transform.localRotation * Vector3.forward * Time.deltaTime * 25, Space.World);

            if(delay2 < 0){
                go_forward = false;
                if(isLast == false){
                  
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = true;
                } else {
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = false;
                    
                }

            }
        }
        else if (turn_right == true)
        {

            if (turnDegree < 90)
            {
                gameObject.transform.Rotate(0, 5, 0);
                turnDegree += 5;
            }
            else if (turnDegree == 90)
            {
                animator.SetBool("run", false);
                animator.SetBool("idle", true);
            }
            delay2 -= Time.deltaTime;
            
            if(delay2 < 0){
                turnDegree = 0;
                turn_right = false;
                if(isLast == false){
                  
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = true;
                } else {
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = false;
                    
                }
            }
        }
        else if (turn_left == true)
        {

            if (turnDegree < 90)
            {
                gameObject.transform.Rotate(0, -5, 0);
                turnDegree += 5;
            }
            else if (turnDegree == 90)
            {
                animator.SetBool("run", false);
                animator.SetBool("idle", true);
            }
            delay2 -= Time.deltaTime;

            if(delay2 < 0){
                turnDegree = 0;
                turn_left = false;
                if(isLast == false){
                  
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = true;
                } else {
                    GameObject.Find("slideRight").GetComponent<ScrollRightBtn>().moveBool = false;
                    
                }
            }
        }

    }

}