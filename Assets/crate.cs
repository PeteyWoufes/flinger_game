using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour {

	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
