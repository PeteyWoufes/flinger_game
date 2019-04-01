using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressure_pad : MonoBehaviour
{
    // Components
    private Animator anim;

    // Declarations
    public bool activated;

    void Start()
    {
        activated = false;
        anim = GetComponent<Animator>();
    }

    void anim_check()
    {
        anim.SetBool("activated", activated);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activated = true;
        }
    }
    
    void Update()
    {
        anim_check();
    }
}
