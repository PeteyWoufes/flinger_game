using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial_UI : MonoBehaviour {
	
	public void Exit ()
	{
		SceneManager.LoadScene("mainMenu");
	}
}
