using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

/*
클릭 이벤트 => 카메라 위치 이동

!! 첫 블록 생성 좌표를 캔버스 가운데로 설정 O

scroll 스크립트 만들기 -> 버튼에 넣기
버튼에 클릭 이벤트 부여
Start ::	
	1. float x y z 에 첫 블록 좌표로 초기화
	2. index = 0 으로 초기화

클릭 이벤트 발생 
->
카메라 좌표 이동 함수 실행
	void camPosUpdate(){
		카메라 좌표 업데이트 // 서서히 바뀌도록
				   
		index 1 증가
		(index를 public으로 선언해서 codeBlockDisplay의 Update 에서 해당 index를 가진 블럭의 스케일 확대하기.
	}

*/


public class ScrollLeftBtn : MonoBehaviour, IPointerClickHandler
{

    GameObject codeCam = null;
    Vector3 moveRight = new Vector3(24,0,0);
    bool moveBool = false;
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
            codeCam.transform.Translate(this.transform.localRotation * Vector3.left * Time.deltaTime * 23, Space.World);
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
