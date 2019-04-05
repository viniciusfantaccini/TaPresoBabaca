using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour {
	
	public int animeLula, cela1, cela2, cela3, cela4, cela5, cela6, cela7, cela8, cela9, cela10, cela11, cela12, cela13, cela14, celaLula, ordem, firstSave;
	GameObject relogio;
	// Use this for initialization
	public string a;
	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
		PlayerPrefs.SetInt ("ordem", 1);
		PlayerPrefs.SetInt ("msg1", 1);
		PlayerPrefs.SetInt ("firstSave", 0);
	}
	
	// Update is called once per frame
	void Update () {

		ordem = PlayerPrefs.GetInt ("ordem");


		a = SceneManager.GetActiveScene ().name;
		if (PlayerPrefs.GetString ("scene") != "" && PlayerPrefs.GetString ("scene") != null && SceneManager.GetActiveScene().name == "menu" && PlayerPrefs.GetInt("firstSave") == 1) {
			SceneManager.LoadScene (PlayerPrefs.GetString ("scene"));
		} else if (SceneManager.GetActiveScene().name == "menu"){
			PlayerPrefs.SetString ("scene", "patio");
			PlayerPrefs.SetInt ("x", -70);
			PlayerPrefs.SetInt ("y", -210);
			PlayerPrefs.SetString ("anime", "C");
			SceneManager.LoadScene (PlayerPrefs.GetString ("scene"));
		}
		if( PlayerPrefs.GetInt("animeLula") == null){
			PlayerPrefs.SetInt ("animeLula", 1);
		}
		if (ordem == null) {
			PlayerPrefs.SetInt ("ordem", 1);
		}

		if (ordem == 1) {
			
			PlayerPrefs.SetInt ("animeLula", 1);
			// Celas Abertas (1) ou Celas Fechadas (0)
			PlayerPrefs.SetInt ("c1", 1);
			PlayerPrefs.SetInt ("c2", 1);
			PlayerPrefs.SetInt ("c3", 1);
			PlayerPrefs.SetInt ("c4", 1);
			PlayerPrefs.SetInt ("c5", 1);
			PlayerPrefs.SetInt ("c6", 0);
			PlayerPrefs.SetInt ("c7", 0);
			PlayerPrefs.SetInt ("c8", 0);
			PlayerPrefs.SetInt ("c9", 0);
			PlayerPrefs.SetInt ("c0", 0);
			/* Prisioneiros
			    NA CELA
				0 Vaiando
				1 NaCela

				NO PATIO
				2 AndandoAleatorio
				3 Parado
				4 SeguindoOLula

				NO VESTIARIO

				5 NoArmarioAberto
				6 NoArmarioFechado

				NO BANHEIRO

				7 NoChuveiro
			*/
			PlayerPrefs.SetInt ("pri0", 0);
			// Protões Abertos (1) ou Celas Fechados (0)
			PlayerPrefs.SetInt ("pCelas", 1);
			PlayerPrefs.SetInt ("pFora", 0);
			PlayerPrefs.SetInt ("pVisitas", 1);
			PlayerPrefs.SetInt ("pVestiario", 1);
			PlayerPrefs.SetInt ("pRefeitorio", 0);
			PlayerPrefs.SetInt ("pMedico", 0);
			PlayerPrefs.SetInt ("pSolitaria", 0);
			PlayerPrefs.SetInt ("pLula", 1);
			// Passou da Missão 1
			PlayerPrefs.SetInt ("firstSave", 0);
			VisibilidadeMensagem ("msg1", 1);
			// Quarto LULA
			PlayerPrefs.SetInt ("TV", 0);
			PlayerPrefs.SetInt ("RoupaPrisao",1);

			PlayerPrefs.SetInt ("ordem",0);
		} else if (ordem == 2) {
			PlayerPrefs.SetInt ("RoupaPrisao", 0);
			PlayerPrefs.SetInt ("firstSave", 1);
			PlayerPrefs.SetInt ("animeLula", 0);
			PlayerPrefs.SetInt ("ordem",0);
		}

	}
	void VisibilidadeMensagem(string msg, int visibilidade){
		if (PlayerPrefs.GetInt (msg) != 2 || PlayerPrefs.GetInt ("firstSave") != 1) {
			PlayerPrefs.SetInt (msg, visibilidade);
		}

	}
}
