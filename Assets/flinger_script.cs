using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flinger_script : MonoBehaviour {

	public bool shot_fired;
	public Rigidbody2D RB2D;
	public Vector2 startPos;
	public Vector2 endPos;
	public Vector2 angle;
	public float distance;
	public float maxVelocity;

	void Start ()
	{
		RB2D = GetComponent<Rigidbody2D>();
		shot_fired = false;
	}
	void get_angle()
	{
		angle = startPos - endPos;
	}
	public void launch ()
	{
		get_angle();
		RB2D.AddForce((distance * angle), ForceMode2D.Impulse);
		shot_fired = true;
	}
	void OnMouseDown () 
	{
		// Debug.Log("BEEP");
		startPos = Input.mousePosition;
	}
	void OnMouseUp ()
	{
		// Debug.Log("BOOP");
		endPos = Input.mousePosition;
		launch();
	}
	void get_distance()
	{
		distance = 0.01f * Vector2.Distance(startPos, endPos);
		Debug.Log("" + distance);
	}
	void Update()
	{
		get_distance();
	}

    void FixedUpdate()
    {
    	// get_angle();
		// get_distance();
		if (RB2D.velocity.x > maxVelocity)
		{
			RB2D.velocity = new Vector2(maxVelocity, RB2D.velocity.y);
		}
		if (RB2D.velocity.x < -maxVelocity)
		{
			RB2D.velocity = new Vector2(-maxVelocity, RB2D.velocity.y);
		}
		if (RB2D.velocity.y > maxVelocity)
		{
			RB2D.velocity = new Vector2(RB2D.velocity.x, maxVelocity);
		}
		if (RB2D.velocity.x < -maxVelocity)
		{
			RB2D.velocity = new Vector2(RB2D.velocity.x, maxVelocity);
		}
    }
}
