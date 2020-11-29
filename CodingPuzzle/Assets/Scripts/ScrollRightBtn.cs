using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ScrollRightBtn : MonoBehaviour, IPointerClickHandler
{
    GameObject codeCam = null;
    
    Vector3 moveRight = new Vector3(24,0,0);
    public bool moveBool = false;
    public float delay = 1.0f;

    // Start is called before the first frame update
    void Awake(){
        codeCam = GameObject.FindWithTag("codeCam");
    }

    void Start()
    {
    }

    void Update(){
        if(moveBool == true){
            //codeCam.transform.position = Vector3.Lerp(codeCam.transform.position, codeCam.transform.position + moveRight, Time.deltaTime);
            codeCam.transform.Translate(this.transform.localRotation * Vector3.right * Time.deltaTime * 23, Space.World);
            delay -= Time.deltaTime;
            
            if(delay <= 0){
                moveBool = false;
                delay = 1.0f;
            }
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        moveBool = true;
    }

    
}
