using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flinger_script : MonoBehaviour {

	// Declarations
    public bool shot_fired;
    public float distance;
	public float force;
	public float maxVelocity;

    // Vectors    
	public Vector2 startPos;
	public Vector2 endPos;
	public Vector2 angle;
    
    // Components
	public Rigidbody2D RB2D;

	void Start ()
	{
        RB2D = GetComponent<Rigidbody2D>();

		shot_fired = false;
        RB2D.isKinematic = true;
        
        startPos = transform.position;
        RB2D.velocity = new Vector2(0, 0);

	}

	public void launch ()
	{
		// Get angle and add force
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
        {
        	angle = angle.normalized * radius;
        }
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
