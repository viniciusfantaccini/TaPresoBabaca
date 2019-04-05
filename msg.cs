using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msg : MonoBehaviour {

	public float largura; // 0 a 100% da tela
	public bool ultima;
	public GameObject proxima;
	public string id;
	private GameObject analogico;
	public float proporcaoAltura;
	RectTransform r;
	Vector3 posi;
	float h,w;
	public bool alturaIndependente;
	int visib;
	// Use this for initialization
	void Start () {
		visib = PlayerPrefs.GetInt (id);
		if (visib != 1) {
			gameObject.SetActive (false);
		}
		Time.timeScale = 0;
		r = GetComponent < RectTransform > ();


	}
	
	// Update is called once per frame
	void Update () {
		w = Screen.width * largura / 100;
		if (!alturaIndependente) {
			h = w * proporcaoAltura;
		} else {
			h = Screen.height * proporcaoAltura / 100;
		}
		r.localScale = new Vector3 (1, 1, 1);
		r.sizeDelta = new Vector2 (w, h);
		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) {
			if (ultima) {
				Time.timeScale = 1;
			} else {
				proxima.SetActive (true);
			}

			gameObject.SetActive (false);
			PlayerPrefs.SetInt (id,2);
		}
	}
}
