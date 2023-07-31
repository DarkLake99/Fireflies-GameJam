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
    public void ChangeScene(string sceneN)
    {
        Debug.Log("why u no workkkkkkkkkKKKK");
        SceneManager.LoadScene(sceneN);
    }

    public void QuitGame()
    {
        Debug.Log("initial victories");
        Application.Quit();
    }
}
