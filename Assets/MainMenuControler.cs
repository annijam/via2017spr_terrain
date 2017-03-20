using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControler : MonoBehaviour {

	public void Play()
    {
        Debug.Log("play pressed");
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("quit pressed");
        Application.Quit();
    }
}
