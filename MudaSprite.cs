using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaSprite : MonoBehaviour {
	public Sprite animeLula1, animeLula0;
	public GameObject lula;
	private SpriteRenderer spriteR;
	// Use this for initialization
	void Start () {
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		if (PlayerPrefs.GetInt ("animeLula") == 0) {
			spriteR.sprite = animeLula0;
		} else if (PlayerPrefs.GetInt ("animeLula") == 1) {
			spriteR.sprite = animeLula1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
