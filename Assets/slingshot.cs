﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slingshot : MonoBehaviour
{
	// Declarations
    public bool occupied;
	public bool targeting;

    // Components
    public GameObject player_prefab;
	public Transform spawn_pos;

	void Start ()
	{
        spawn_next();
	}

    void FixedUpdate()
    {
        if (!occupied && !sceneMoving())
		{
            spawn_next();
		}
    }

    void spawn_next()
    {
        Instantiate(player_prefab, spawn_pos.position, Quaternion.identity);
		occupied = true;
    }

	void OnTriggerExit2D(Collider2D col)
	{
		occupied = false;
	}

	bool sceneMoving ()
	{
		foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
		{
			Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
			if (rb.IsSleeping() == false)
			{
				return true;
			}
		}
		return false;
	}
}
