using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainManu()
    {
        SceneManager.LoadScene(0);
    }

    //below here are car Selection Buttons
    public void Area01()
    {
        SceneManager.LoadScene(2);
    }
    public void Area02()
    {
        SceneManager.LoadScene(3);
    }
    public void CreditScene()
    {
        SceneManager.LoadScene(4);
    } 
}
