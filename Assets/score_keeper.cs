using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_keeper : MonoBehaviour
{   
	private GameObject score_object;
	private Text score_text;
	public int score; 
	public int max_score;

	// Victory and Game toggling

	private GameObject game_UI;
	private GameObject victory_UI;

    void Start()
    {
		score_object = GameObject.FindGameObjectWithTag("score_text");
		score_text = score_object.GetComponent<Text>();
		score = 0;

		game_UI = GameObject.FindGameObjectWithTag("game_UI");
		victory_UI = GameObject.FindGameObjectWithTag("victory_UI");

		game_UI.SetActive(true);
		victory_UI.SetActive(false);
    }

    void Update()
    {
        score_text.text = "Score: " + score;
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
