using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLargura : MonoBehaviour {

	// Use this for initialization
	RectTransform r;
	Vector3 posi;
	float h;
	public float scale;
	void Start () {
		r = GetComponent < RectTransform > ();			
	}

	// Update is called once per frame
	void Update () {
		h = Screen.width / scale;
		r.localScale = new Vector3 (1, 1, 1);
		r.sizeDelta = new Vector2 (h, h);
	}
}
