using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject Explosion;
	public string[] Background;



	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		
		if (other.gameObject.tag == "Target") {	
			other.gameObject.BroadcastMessage ("React");
			Player.lives++;
			Shoot.b++;
			Player.enemies++;
		}

		Instantiate (Explosion,transform.position, Quaternion.identity);

		Destroy (gameObject);
		
	}


}
