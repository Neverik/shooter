using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	private Rigidbody rb;
	public float power = 1f;
	private int bullets = 10;
	public Text tex;
	public static int b = 0;

	void Awake() {
		bullets = 10;
	}

	void Start() {
		tex.GetComponent <Text> ().text = "Bullets: " + bullets.ToString();
	}

	void Update () {
		tex.GetComponent <Text> ().text = "Bullets: " + bullets.ToString();
		if (Input.GetKeyDown (KeyCode.R) && bullets <= 0 && b > 0) {bullets = 10;}
		if (Input.GetKeyDown(KeyCode.Mouse0) && bullets > 0) {
			 
			GameObject gm = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject;

			rb = gm.GetComponent <Rigidbody> ();

			rb.AddForce (transform.forward * power, ForceMode.Impulse);	

			bullets--;

		}
	}
}
