using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_master : MonoBehaviour
{   
	// Declarations
    public int score; 
	public int max_score;
    
    // Text components
    private GameObject scoretext_UIobject;
	private Text scoretext_text;
    
    // UI Parent GameObjects
	private GameObject game_UI;
	private GameObject victory_UI;

    void Start()
    {
        scoretext_UIobject = GameObject.FindGameObjectWithTag("score_text");
		scoretext_text = scoretext_UIobject.GetComponent<Text>();
		game_UI = GameObject.FindGameObjectWithTag("game_UI");
		victory_UI = GameObject.FindGameObjectWithTag("victory_UI");

        score = 0;
		game_UI.SetActive(true);
		victory_UI.SetActive(false);
    }

    void Update()
    {
        scoretext_text.text = "Score: " + score;
		victory_check();
    }

	void victory_check()
	{
		if (score >= max_score)
		{
			game_UI.SetActive(false);
			victory_UI.SetActive(true);
			Time.timeScale = 0f;
		}
	}

	public void next_level()
	{
		Scene curScene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(curScene.buildIndex + 1);
	}
}
