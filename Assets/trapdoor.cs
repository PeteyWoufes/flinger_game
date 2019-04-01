using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapdoor : MonoBehaviour
{
	public pressure_pad PRESSURE_PAD;
    void Start()
    {
		
    }

    void Update()
    {
        open_check();
    }

	void open_check()
	{
		if (PRESSURE_PAD.activated == true)
		{
			Destroy(gameObject);
		}
	}
}
