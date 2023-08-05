using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button start;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void mainScene()
    {
        Debug.Log("go to main menu");
        SceneManager.LoadScene(0);
    }
    public void ChangeScene(string sceneN)
    {
        Debug.Log("changing scene frm "+ this.name + " to " + sceneN);
        SceneManager.LoadScene(sceneN);
    }

    public void QuitGame()
    {
        Debug.Log("initial victories");
        Application.Quit();
    }
}
