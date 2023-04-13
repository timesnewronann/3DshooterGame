using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void ExitGame(){
    //close the game
        Debug.Log("QUITTING GAME");
        Application.Quit();
    }
}
