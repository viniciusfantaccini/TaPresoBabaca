using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TV : MonoBehaviour {

	public GameObject btnLigar;
	public GameObject btnDesligar;
	public bool colidiu;
	public bool botaoLigarApertado;
	public bool botaoDesligarApertado;
	public GameObject luzTV;
	public int antiLoop, antiLoop2;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("TV") != 0) {
			luzTV.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		botaoLigarApertado = CrossPlatformInputManager.GetButton("LigarTV");
		botaoDesligarApertado = CrossPlatformInputManager.GetButton("DesligarTV");
		if (botaoLigarApertado || botaoDesligarApertado) {
			antiLoop = 1;
		} else {
			antiLoop = 0;
		}
		botaoLigarApertado = CrossPlatformInputManager.GetButton("LigarTV");
		botaoDesligarApertado = CrossPlatformInputManager.GetButton("DesligarTV");
		if (botaoLigarApertado && colidiu && (antiLoop != antiLoop2)) {
			luzTV.SetActive (true);
			PlayerPrefs.SetInt ("TV", 1);
		}
		if (botaoDesligarApertado && colidiu && (antiLoop != antiLoop2)) {
			luzTV.SetActive (false);
			PlayerPrefs.SetInt ("TV", 0);
		}
		if (botaoLigarApertado || botaoDesligarApertado) {
			antiLoop2 = 1;
		} else {
			antiLoop2 = 0;
		}
		botaoLigarApertado = CrossPlatformInputManager.GetButton("LigarTV");
		botaoDesligarApertado = CrossPlatformInputManager.GetButton("DesligarTV");
	}

	void OnTriggerStay2D(Collider2D other) {

		if (other.tag == "Player") {
			if (PlayerPrefs.GetInt ("TV") == 0) {
				btnDesligar.SetActive (false);
				btnLigar.SetActive (true);
			} else {
				btnLigar.SetActive (false);
				btnDesligar.SetActive (true);
			}
			colidiu = true;
		}

	}
	void OnTriggerExit2D(Collider2D other) {
		if (other.tag == "Player") {
			btnLigar.SetActive (false);
			btnDesligar.SetActive (false);
			colidiu = false;
		}
	}
}
