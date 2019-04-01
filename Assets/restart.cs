using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{

    void __restart ()
    {
		Scene curScene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(curScene.name);
    }

	void __mainMenu()
	{
		SceneManager.LoadScene("mainMenu");
	}
    
	void restartCheck ()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			__restart();
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			__mainMenu();
		}
	}

	void Update ()
	{
		restartCheck();
	}
}
