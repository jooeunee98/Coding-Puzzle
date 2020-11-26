using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    int currentSceneNo;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneNo = SceneManager.GetActiveScene().buildIndex;
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(currentSceneNo + 1);
        audio.Play();
    }

    public void restartScene()
    {
        SceneManager.LoadScene(currentSceneNo);
        audio.Play();
    }

    public void goHome()
    {
        SceneManager.LoadScene(0);
    }

    public void exitGame()
    {
        Application.Quit();
        audio.Play();
    }
}
