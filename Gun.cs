using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject bullet;
	public Transform player;
	private float i = 0;
	private float timer;
	public Transform instantiateat;

	// Use this for initialization
	void Start () {
		timer = Random.Range (40f, 60f);
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		transform.LookAt (player);
		transform.rotation = new Quaternion (0, transform.rotation.y, 0, transform.rotation.w);
		if (i > timer && Vector3.Distance(transform.position, player.position) < 50) {
			GameObject rb = Instantiate (bullet, instantiateat.position, Quaternion.identity) as GameObject;
			rb.GetComponent <Rigidbody> ().velocity = transform.forward*100f;
			i = 0f;
		}
	}
}
