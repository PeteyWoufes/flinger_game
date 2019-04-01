using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    // Declarations
    public bool destroy_on_contact;
    public bool in_tutorial;

    // Components
    private GameObject gamemaster_object;
    private game_master gamemaster_script;

    void Start()
    {
        if (!in_tutorial)
        {
            gamemaster_object = GameObject.FindGameObjectWithTag("GAMEMASTER");
            gamemaster_script = gamemaster_object.GetComponent<game_master>();
            gamemaster_script.max_score += 1;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (destroy_on_contact == true && !in_tutorial)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                // Add point and destroy object
                gamemaster_script.score += 1;
                Destroy(gameObject);
            }
        }
    }
}
