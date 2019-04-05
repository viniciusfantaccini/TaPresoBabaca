using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cela : MonoBehaviour {

	public GameObject parteSuperior;
	public string id;
	public int aberta;
	public GameObject parede;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		aberta = PlayerPrefs.GetInt (id);
		if (aberta == 0) {
			parede.SetActive (true);
		} else {
			parede.SetActive (false);
		}

	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player" && aberta == 1) {
			parteSuperior.SetActive (false);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.tag == "Player") {
			parteSuperior.SetActive (true);
		}
	}
}
