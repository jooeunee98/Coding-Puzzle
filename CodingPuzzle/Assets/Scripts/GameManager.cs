using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int stageNum = 1;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Stage02")
        {
            stageNum = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Stage03")
        {
            stageNum = 3;
        }
        else if (SceneManager.GetActiveScene().name == "Stage04")
        {
            stageNum = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Stage05")
        {
            stageNum = 5;
        }
        else if (SceneManager.GetActiveScene().name == "Stage06")
        {
            stageNum = 6;
        }
        else if (SceneManager.GetActiveScene().name == "Stage07")
        {
            stageNum = 7;
        }
        else if (SceneManager.GetActiveScene().name == "Stage08")
        {
            stageNum = 8;
        }
        else if (SceneManager.GetActiveScene().name == "Stage09")
        {
            stageNum = 9;
        }
        StartCoroutine(MakeStage());
    }

    void Update()
    {

    }

    IEnumerator MakeStage()
    {
        float x = 0;
        float z = 0;
        string[] str = GroundSet.stage[stageNum - 1];

        foreach (string t in str)
        {
            char[] ch = t.Trim().ToCharArray();
            x = 0;
            foreach (char c in ch)
            {
                switch (c)
                {

                    case '1':
                        GameObject Ground1 = Instantiate(Resources.Load("prefab/Grass 01")) as GameObject;
                        int y1 = 55;
                        int s1 = 0;
                        for (int k = 0; k <= 5; k++)
                        {
                            Ground1.transform.position = new Vector3(x, y1, z);
                            Ground1.transform.localScale = new Vector3(s1, s1, s1);
                            yield return new WaitForSeconds(0.02f);
                            y1 += 2;
                            s1 += 5;

                        }
                        for (int k = 0; k <= 5; k++)
                        {
                            Ground1.transform.position = new Vector3(x, y1, z);
                            yield return new WaitForSeconds(0.02f);
                            y1 -= 2;

                        }
                        x+=25;
                        break;

                    case '2':
                        GameObject Water1 = Instantiate(Resources.Load("prefab/Water 01")) as GameObject;
                        GameObject Water2 = Instantiate(Resources.Load("prefab/Water 02")) as GameObject;
                        int y2 = 55;
                        int s2 = 0;
                        int y3 = 55;
                        int s3 = 0;
                        for (int k = 0; k <= 5; k++)
                        {
                            Water1.transform.position = new Vector3(x, y2, z);
                            Water1.transform.localScale = new Vector3(s2, s2, s2);
                            Water2.transform.position = new Vector3(x, y3, z);
                            Water2.transform.localScale = new Vector3(s3, s3, s3);
                            yield return new WaitForSeconds(0.02f);
                            y3 += 2;
                            s3 += 5;
                            y2 += 2;
                            s2 += 5;

                        }
                        for (int k = 0; k <= 5; k++)
                        {
                            Water1.transform.position = new Vector3(x, y2, z);
                            Water2.transform.position = new Vector3(x, y3, z);
                            yield return new WaitForSeconds(0.02f);
                            y2 -= 2;
                            y3 -= 2;
                        }
                        x+=25;
                        break;

                    case '3':
                        x+=25;
                        break;


                   


                }
            }

            //한줄 아래로 이동
            z+=25;
        }
      
        StartCoroutine(MakeMaze());

    }

    IEnumerator MakeMaze()
    {
        int x = 0;
        int z = 0;
        string[] str = StageSet.stage[stageNum - 1];

        foreach (string t in str)
        {
            char[] ch = t.Trim().ToCharArray();
            x = 0;
            foreach (char c in ch)
            {
                switch (c)
                {

                    case '1':
                        GameObject tree1 = Instantiate(Resources.Load("prefab/Tree01")) as GameObject;
                        float y1 = 55f;
                        int s1 = 0;
                        for (int k = 0; k <= 5; k++)
                        {
                            tree1.transform.position = new Vector3(x, y1, z);
                            tree1.transform.localScale = new Vector3(s1, s1, s1);
                            yield return new WaitForSeconds(0.02f);
                            y1 += 1.4f;
                            s1 += 2;

                        }
                        for (int k = 0; k <= 5; k++)
                        {
                            tree1.transform.position = new Vector3(x, y1, z);
                            yield return new WaitForSeconds(0.02f);
                            y1 -= 1.5f;

                        }
                        x+=25;
                        break;

                    case '2':
                        GameObject tree2 = Instantiate(Resources.Load("prefab/Tree02")) as GameObject;
                        float y2 = 55f;
                        int s2 = 0;
                        for (int k = 0; k <= 5; k++)
                        {
                            tree2.transform.position = new Vector3(x, y2, z);
                            tree2.transform.localScale = new Vector3(s2, s2, s2);
                            yield return new WaitForSeconds(0.02f);
                            y2 += 3.1f;
                            s2 += 2;

                        }
                        for (int k = 0; k <= 5; k++)
                        {
                            tree2.transform.position = new Vector3(x, y2, z);
                            yield return new WaitForSeconds(0.02f);
                            y2 -= 1.5f;

                        }
                        
                        x+=25;
                        break;

                    case '3':
                        x+=25;
                        break;



                    case '5':
                        GameObject target = Instantiate(Resources.Load("prefab/Target")) as GameObject;
                        target.transform.position = new Vector3(x, 0, z);
                        float y4= 55f;
                        int s4 = 0;
                        for (int k = 0; k <= 5; k++)
                        {
                            target.transform.position = new Vector3(x, y4, z);
                            target.transform.localScale = new Vector3(s4, s4, s4);
                            yield return new WaitForSeconds(0.02f);
                            y4 += 2f;
                            s4 += 2;

                        }
                        for (int k = 0; k <=5; k++)
                        {
                            target.transform.position = new Vector3(x, y4, z);
                            yield return new WaitForSeconds(0.02f);
                            y4 -= 2f;

                        }
                        x+=25;
                        break;


                }
            }

            //한줄 아래로 이동
            z+=25;
        }
    }

 



}
