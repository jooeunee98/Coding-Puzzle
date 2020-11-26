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

    int[] commandLoaded;
    private IEnumerator coroutine;
    bool go_forward = false;
    bool turn_right = false;
    bool turn_left = false;
    int turnDegree = 0;

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
        coroutine = readCommand(3.0f);
        StartCoroutine(coroutine);

    }

    public IEnumerator readCommand(float waitTime)
    {
        for (int i = 0; i < commandLoaded.Length; i++)
        {

            if (commandLoaded[i] == 1)
            {
                animator.SetBool("idle", false);
                animator.SetBool("run", true);
                animator.SetBool("turn", false);
                waitTime = 1.0f;
                go_forward = true;
                turn_left = false;
                turn_right = false;
            }
            else if (commandLoaded[i] == 2)
            {
                if (i == 1)
                    animator.SetBool("idle", false);
                animator.SetBool("run", false);
                animator.SetBool("turn", true);
                go_forward = false;
                turn_right = true;
                turn_left = false;
                waitTime = 3f;
            }
            else if (commandLoaded[i] == 3)
            {
                animator.SetBool("idle", false);
                animator.SetBool("run", false);
                animator.SetBool("turn", true);
                go_forward = false;
                turn_left = true;
                turn_right = false;
                waitTime = 3f;
            }
            else
            {
                go_forward = false;
                turn_left = false;
                turn_right = false;
            }
            yield return new WaitForSeconds(waitTime);

        }
        animator.SetBool("idle", true);
        animator.SetBool("run", false);
        animator.SetBool("turn", false);
        go_forward = false;
        turn_left = false;
        turn_right = false;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("commandLoaded Length : " + commandLoaded.Length);
        comNum = array.GetComponent<commandList>().command.Length;

        //Debug.Log(comNum);

        for (int i = 0; i < comNum; i++)
        {
            commandLoaded[i] = array.GetComponent<commandList>().command[i];
            Debug.Log(commandLoaded[i]);
        }
        if (go_forward == true)
        {
            transform.Translate(this.transform.localRotation * Vector3.forward * Time.deltaTime * 25, Space.World);
        }
        else if (turn_right == true)
        {
            if (turnDegree < 90)
            {
                Debug.Log("turnDegree : " + turnDegree);
                gameObject.transform.Rotate(0, 5, 0);
                turnDegree += 5;
            }
            else if (turnDegree == 90)
            {
                Debug.Log("Ok by here");
                turnDegree = 0;
                turn_right = false;
            }
        }
        else if (turn_left == true)
        {
            if (turnDegree <= 90)
            {
                gameObject.transform.Rotate(0, -5, 0);
                turnDegree += 5;
            }

        }

    }

}