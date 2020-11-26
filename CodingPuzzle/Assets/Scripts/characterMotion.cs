using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMotion : MonoBehaviour
{
    private Animator animator;

    public GameObject array;
    public int comNum = 0;
    public int[] commandLoaded;
    private void Awake()
    {
        // Awake 필요가 없네
        // comNum = array.GetComponent<commandList>().command.Length;
        
        // animator = GetComponent<Animator>(); 
    }
    private IEnumerator coroutine;
    bool go_forward = false;
    bool turn_right = false;
    bool turn_left = false;
    float stRotationY;
    int turnDegree = 0;
    // Start is called before the first frame update
    void Start()
    {
        comNum = array.GetComponent<commandList>().command.Length;
        for(int i=0; i<comNum; i++)
        {
            commandLoaded[i] = array.GetComponent<commandList>().command[i];
        }
        animator = GetComponent<Animator>();
        coroutine = readCommand(1.0f);
        StartCoroutine(coroutine);

    }

    public IEnumerator readCommand(float waitTime){
        for(int i=0; i<commandLoaded.Length; i++){
            Debug.Log(i);
            if(commandLoaded[i] == 1){
                animator.SetBool("idle", false);
                animator.SetBool("run", true);
                animator.SetBool("turn", false);
                waitTime = 1.0f;
                go_forward = true;
            } else if(commandLoaded[i] == 2){
                animator.SetBool("idle", false);
                animator.SetBool("run", false);
                animator.SetBool("turn", true);
                go_forward = false;
                turn_right = true;
                turnDegree = 0;
                // 도는건 얼마 안걸리니까 waitTime -> 1 로 변경
                waitTime = 2f;
            } else if(commandLoaded[i] == 3){
                animator.SetBool("idle", false);
                animator.SetBool("run", false);
                animator.SetBool("turn", true);
                go_forward = false;
                turn_left = true;
                turnDegree = 0;
                // 도는건 얼마 안걸리니까 waitTime -> 1 로 변경
                waitTime = 2f;
            }
            yield return new WaitForSeconds(waitTime);

        }
        animator.SetBool("idle", true);
        animator.SetBool("run", false);
        animator.SetBool("turn", false);
        go_forward = false;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<comNum; i++){
            commandLoaded[i] = array.GetComponent<commandList>().command[i];
        }
        if(go_forward == true){
            transform.Translate(this.transform.localRotation * Vector3.forward * Time.deltaTime * 25, Space.World);
        }
        else if(turn_right == true){
            if(turnDegree < 90){
                gameObject.transform.Rotate(0,2,0);
                turnDegree+=2;
             } 
        } else if(turn_left == true){
            if(turnDegree < 90){
                gameObject.transform.Rotate(0,-2,0);
                turnDegree+=2;
             } 

        } 
        
    }

}
