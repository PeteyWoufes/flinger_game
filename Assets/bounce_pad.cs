using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce_pad : MonoBehaviour
{
    // Declarations
    public int bounce_force;

    void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(bounce_force * Vector2.up, ForceMode2D.Impulse);
    }
}
