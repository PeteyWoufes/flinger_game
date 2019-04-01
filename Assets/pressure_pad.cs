using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressure_pad : MonoBehaviour
{
    public bool activated;
    private Animator anim;
    void Start()
    {
        activated = false;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim_check();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activated = true;
        }
    }

    void anim_check()
    {
        anim.SetBool("activated", activated);
    }
}
