using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour {

	private GameObject camera_object;
	private score_keeper scorekeeper;
	public bool destroy_on_contact;

	void Start ()
	{
		camera_object = GameObject.FindGameObjectWithTag("MainCamera");
		scorekeeper = camera_object.GetComponent<score_keeper>();
		scorekeeper.max_score += 1;
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if (destroy_on_contact == true)
		{
			if(other.gameObject.CompareTag("Player"))
			{
				scorekeeper.score += 1;
				Destroy(gameObject);
			}
		}
		else
		{
			print("Player collided with " + gameObject.name);
		}
	}
}
