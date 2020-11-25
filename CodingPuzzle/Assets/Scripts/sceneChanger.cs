using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public int currentSceneNo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(currentSceneNo + 1);
    }

    public void restartScene()
    {
        SceneManager.LoadScene(currentSceneNo);
    }
}
