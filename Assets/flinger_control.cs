using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flinger_control : MonoBehaviour {

	public flinger_script player;
	public Vector2 __startPos;
	public Vector2 __endPos;

	void OnMouseDown ()
	{
		player.startPos = Input.mousePosition;
		// player.startPos = __startPos;
	}

	void OnMouseUp ()
	{
		player.endPos = Input.mousePosition;
		// player.endPos = __endPos;
		player.launch();
	}
}
