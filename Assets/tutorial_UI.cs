using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial_UI : MonoBehaviour {
	
	public void exit_tutorial ()
	{
		SceneManager.LoadScene("mainMenu");
	}
}
