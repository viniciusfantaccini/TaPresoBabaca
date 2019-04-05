using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portao : MonoBehaviour {

	public Animator anime;
	int aberta;
	public string id;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		aberta = PlayerPrefs.GetInt (id);
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && aberta == 1) {
			anime.SetBool ("Abrir", true);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Player") {
			anime.SetBool ("Abrir", false);
		}
	}
}
