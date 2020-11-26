using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    int currentSceneNo;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneNo = SceneManager.GetActiveScene().buildIndex;
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

    public void goHome()
    {
        SceneManager.LoadScene(0);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
