using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void StartGame()
    {
		SceneManager.LoadScene("Gameboard");
    }

    public void ExitGame()
    {
        Debug.Log("WE'RE EXITING THE GAME");
        Application.Quit();
    }
}
