using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {
	private Camera player_camera;
	public flinger_script player_flinger;
	public GameObject player;
	public float camera_offset;
	public float zoom_level;
	void Start () 
	{
		transform.position = new Vector3(player.transform.position.x - camera_offset, transform.position.y, transform.position.z);
		player_camera = GetComponent<Camera>();
		player = GameObject.FindGameObjectWithTag("Player");
	}
	void follow ()
	{
		transform.position = new Vector3(player.transform.position.x - camera_offset, transform.position.y, transform.position.z);
	}

	void zoom ()
	{
		if (player_camera.orthographicSize > zoom_level)
		{
			player_camera.orthographicSize = zoom_level;
		}
	}

	void track_and_zoom ()
	{
		if (player_flinger.shot_fired)
		{
			follow();
			zoom();
		}
	}
	
	void Update () 
	{
		track_and_zoom();
	}
}
