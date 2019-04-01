using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flinger_script : MonoBehaviour {

	public bool shot_fired;
	private slingshot slingshot_object;
	public Rigidbody2D RB2D;
	public Vector2 startPos;
	public Vector2 endPos;
	public Vector2 angle;
	public float distance;
	public float force;
	public float maxVelocity;

	void Start ()
	{
		RB2D = GetComponent<Rigidbody2D>();
		RB2D.isKinematic = true;
		RB2D.velocity = new Vector2(0, 0);
		startPos = transform.position;
		shot_fired = false;
		slingshot_object = GameObject.FindGameObjectWithTag("slingshot_object").GetComponent<slingshot>();
	}

	public void launch ()
	{
		Vector2 dir = startPos - (Vector2)transform.position;
		RB2D.AddForce((force * dir), ForceMode2D.Impulse);
		shot_fired = true;
	}
	void OnMouseDrag () 
	{
		endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float radius = 1.8f;
    	Vector2 angle = endPos - startPos;
    	if (angle.sqrMagnitude > radius)
        	angle = angle.normalized * radius;
		transform.position = startPos + angle;
	}
	void OnMouseUp ()
	{
		RB2D.isKinematic = false;
		launch();
		Time.timeScale = 0.8f;
		Destroy(this);
	}
}
