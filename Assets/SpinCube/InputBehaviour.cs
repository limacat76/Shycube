using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpincubeMotion component = GetComponent<SpincubeMotion>();
            component.MustOrbit = !component.MustOrbit;
        }
    }
}
