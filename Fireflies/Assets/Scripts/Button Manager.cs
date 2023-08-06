using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SettingsMenuOn(GameObject settings)
    {
        Debug.Log("heh you thought");
        settings.SetActive(true);
        //Settings menu. enable
        //time.scale =0;
    }
    //void SettingsMenuOff()
    //{

    //}
    public void mainScene()
    {
        Debug.Log("go to main menu");
        SceneManager.LoadScene(0);
    }
    public void ChangeScene(string sceneN)
    {
        Debug.Log("changing scene frm "+ SceneManager.GetActiveScene() + " to " + sceneN);
        SceneManager.LoadScene(sceneN);
    }
    public void resetScene()
    {
        Debug.Log("resetting scene");
        Scene scene = SceneManager.GetActiveScene();
        ChangeScene(scene.name);
    }
    public void QuitGame()
    {
        Debug.Log("initial victories");
        Application.Quit();
    }
}
