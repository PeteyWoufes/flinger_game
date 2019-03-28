using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echo : MonoBehaviour {

	private float time_between_echo;
	public float start_time_between_echo;

	private flinger_script player;
	public GameObject echo_obj;

	void Start () 
	{
		player = GetComponent<flinger_script>();
	}
	
	void Update () 
	{
		if (time_between_echo <= 0)
		{
			GameObject instance = (GameObject)Instantiate(echo_obj, transform.position, Quaternion.identity);
			Destroy(instance, 4f);
			time_between_echo = start_time_between_echo;
		}
		else
		{
			time_between_echo -= Time.deltaTime;
		}
	}
}
