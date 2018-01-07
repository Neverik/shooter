using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "Bullet") {
			Destroy (gameObject);
		}
	}

	void Start() {
		gameObject.tag = "Target";
	}

	void React () {
		Destroy (gameObject);
	}
}
