using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu_UI : MonoBehaviour {

	public void Play ()
	{
		SceneManager.LoadScene("B1_L1");
	}

	public void HowToPlay ()
	{
		SceneManager.LoadScene("tutorial");
	}

}
