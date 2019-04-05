using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horario : MonoBehaviour {

	bool play = true;

	public GameObject referencia;
	public GameObject h1, h2, h3 ,h4 ,h5, h6, h7, h8, h9, h10, h11, h12, m1, m2, m3 ,m4 ,m5, m6, m7, m8, m9, m10, m11, m12;
	public float velocidade;
	public int h = 0;
	public int m = 0;
	public bool dia = true;
	int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (play) {
			referencia.transform.Translate (Vector3.right * velocidade * Time.deltaTime);
		}
		if (referencia.transform.position.x >= 120) {
			referencia.transform.position = new Vector3 (0, 0, 0);
			dia = !dia;
		}
		if (referencia.transform.position.x < 10) {
			h = 0;

		} else if (referencia.transform.position.x < 20) {
			h = 1;

		} else if (referencia.transform.position.x < 30) {
			h = 2;

		} else if (referencia.transform.position.x < 40) {
			h = 3;

		} else if (referencia.transform.position.x < 50) {
			h = 4;

		} else if (referencia.transform.position.x < 60) {
			h = 5;

		} else if (referencia.transform.position.x < 70) {
			h = 6;

		} else if (referencia.transform.position.x < 80) {
			h = 7;

		} else if (referencia.transform.position.x < 90) {
			h = 8;

		} else if (referencia.transform.position.x < 100) {
			h = 9;

		} else if (referencia.transform.position.x < 110) {
			h = 10;

		} else if (referencia.transform.position.x < 120) {
			h = 11;
		}
		AnimacaoHora (h);

			if (referencia.transform.position.x % 12 < 1) {
				m = 0;
			} else if (referencia.transform.position.x % 12 < 2) {
				m = 5;
			} else if (referencia.transform.position.x % 12 < 3) {
				m = 10;
			} else if (referencia.transform.position.x % 12 < 4) {
				m = 15;
			} else if (referencia.transform.position.x % 12 < 5) {
				m = 20;
			} else if (referencia.transform.position.x % 12 < 6) {
				m = 25;
			} else if (referencia.transform.position.x % 12 < 7) {
				m = 30;
			} else if (referencia.transform.position.x % 12 < 8) {
				m = 35;
			} else if (referencia.transform.position.x % 12 < 9) {
				m = 40;
			} else if (referencia.transform.position.x % 12 < 10) {
				m = 45;
			} else if (referencia.transform.position.x % 12 < 11) {
				m = 50;
			} else if (referencia.transform.position.x % 12 < 12) {
				m = 55;
			}

		AnimacaoMinuto (m);
	}

	void AnimacaoHora (int hora){
		if (hora == 0) {
			h1.SetActive (true);
		} else {
			h1.SetActive (false);
		}

		if (hora == 1) {
			h2.SetActive (true);
		} else {
			h2.SetActive (false);
		}

		if (hora == 2) {
			h3.SetActive (true);
		} else {
			h3.SetActive (false);
		}

		if (hora == 3) {
			h4.SetActive (true);
		} else {
			h4.SetActive (false);
		}

		if (hora == 4) {
			h5.SetActive (true);
		} else {
			h5.SetActive (false);
		}

		if (hora == 5) {
			h6.SetActive (true);
		} else {
			h6.SetActive (false);
		}

		if (hora == 6) {
			h7.SetActive (true);
		} else {
			h7.SetActive (false);
		}

		if (hora == 7) {
			h8.SetActive (true);
		} else {
			h8.SetActive (false);
		}

		if (hora == 8) {
			h9.SetActive (true);
		} else {
			h9.SetActive (false);
		}

		if (hora == 9) {
			h10.SetActive (true);
		} else {
			h10.SetActive (false);
		}

		if (hora == 10) {
			h11.SetActive (true);
		} else {
			h11.SetActive (false);
		}

		if (hora == 11) {
			h12.SetActive (true);
		} else {
			h12.SetActive (false);
		}
	}

	void AnimacaoMinuto(int hora/*preguiça*/){
		hora = hora / 5;
		if (hora == 0) {
			m1.SetActive (true);
		} else {
			m1.SetActive (false);
		}

		if (hora == 1) {
			m2.SetActive (true);
		} else {
			m2.SetActive (false);
		}

		if (hora == 2) {
			m3.SetActive (true);
		} else {
			m3.SetActive (false);
		}

		if (hora == 3) {
			m4.SetActive (true);
		} else {
			m4.SetActive (false);
		}

		if (hora == 4) {
			m5.SetActive (true);
		} else {
			m5.SetActive (false);
		}

		if (hora == 5) {
			m6.SetActive (true);
		} else {
			m6.SetActive (false);
		}

		if (hora == 6) {
			m7.SetActive (true);
		} else {
			m7.SetActive (false);
		}

		if (hora == 7) {
			m8.SetActive (true);
		} else {
			m8.SetActive (false);
		}

		if (hora == 8) {
			m9.SetActive (true);
		} else {
			m9.SetActive (false);
		}

		if (hora == 9) {
			m10.SetActive (true);
		} else {
			m10.SetActive (false);
		}

		if (hora == 10) {
			m11.SetActive (true);
		} else {
			m11.SetActive (false);
		}

		if (hora == 11) {
			m12.SetActive (true);
		} else {
			m12.SetActive (false);
		}	
	}
}
