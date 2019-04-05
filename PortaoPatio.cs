using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaoPatio : MonoBehaviour {

	public Transform porta;
	public GameObject passagem;
	public GameObject collider;
	int posInicial;
	public string id;
	float xInicial, yInicial;
	public bool x;
	public float large;
	// Use this for initialization
	void Start () {
		xInicial = porta.position.x;
		yInicial = porta.position.y;
		posInicial = PlayerPrefs.GetInt (id);
		if (posInicial == 0) {
			if (x) {
				porta.position = new Vector3 (xInicial - large, porta.position.y, porta.position.z);
			} else {
				porta.position = new Vector3 (porta.position.x, yInicial - large, porta.position.z);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (posInicial != PlayerPrefs.GetInt (id)) {
			
		}
		if (PlayerPrefs.GetInt (id) == 0) {
			passagem.SetActive (false);
			collider.SetActive (true);
		} else {
			passagem.SetActive (true);
			collider.SetActive (false);
		}
	}
}
