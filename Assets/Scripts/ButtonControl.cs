using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    void Start(){

    }
    void Update(){

    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void oneP()
    {
        GameControl.nofPlayers = 1;
        SceneManager.LoadScene("SnakeAndLadderMain");
    }

    public void twoP()
    {
        GameControl.nofPlayers = 2;
        SceneManager.LoadScene("SnakeAndLadderMain");
    }

    public void threeP()
    {
        GameControl.nofPlayers = 3;
        SceneManager.LoadScene("SnakeAndLadderMain");
    }

    public void fourP()
    {
        GameControl.nofPlayers = 4;
        SceneManager.LoadScene("SnakeAndLadderMain");
    }
}
