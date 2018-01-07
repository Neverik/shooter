using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	public Text tex;
	public static float lives = 10f;
	public AudioSource audioplay;
	public static int enemies;


	void Awake() {
		lives = 10f;
		enemies = 0;
	}

	void Start () {
		tex.GetComponent <Text> ().text = "Lives : " + Mathf.Ceil(lives/2).ToString ();
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Bullet") {
			audioplay.Play ();
			lives -= 1f;

		}
	}

	public static void Heal () {
		lives++;
	}

	// Update is called once per frame
	void Update () {
		tex.GetComponent <Text> ().text = "Lives : " + Mathf.Ceil(lives/2).ToString ();
		if (lives <= 0f) {
			
			SceneManager.LoadScene (1);

			}

		if (enemies >= 11) {
			SceneManager.LoadScene (2);
		}

	}
}
