using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapdoor : MonoBehaviour
{
	// Components
    public pressure_pad PRESSURE_PAD;

	void open_check()
	{
		if (PRESSURE_PAD.activated == true)
		{
			Destroy(gameObject);
		}
	}

    void Update()
    {
        open_check();
    }
}
