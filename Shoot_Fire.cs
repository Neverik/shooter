using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Fire : MonoBehaviour {

	public GameObject fire;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate (fire, transform.position, Quaternion.identity);
		}
	}
}
