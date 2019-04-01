using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu_UI : MonoBehaviour {

    // Declarations
    public string first_level;
    public string tutorial_level;

	public void Play ()
	{
		SceneManager.LoadScene(first_level);
	}

	public void HowToPlay ()
	{
		SceneManager.LoadScene(tutorial_level);
	}

}
