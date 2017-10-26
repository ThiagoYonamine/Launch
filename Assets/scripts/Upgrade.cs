using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {

	public GameObject[] bars;
	public Text preco;
	public string atributo;
	private int levelAtual;
	private int precoAtual;
	private int dinheiroPlayer;
	// Use this for initialization



	void Start () {
		levelAtual = PlayerPrefs.GetInt (atributo);

		precoAtual = 10 * (int) Mathf.Pow (2, levelAtual);
		dinheiroPlayer = PlayerPrefs.GetInt ("gold");
		preco.text = "$ " + precoAtual.ToString();

		for (int i = 0; i < 8; i++) {
			bars [i].SetActive (false);
		}
		for (int i = 0; i < levelAtual; i++) {
			bars [i].SetActive (true);
		}

		if (levelAtual >= 8) {
			preco.text = "MAX";
		}

	}


	public void upgradeItem(){
		if ( dinheiroPlayer >= precoAtual && levelAtual<8) {
			dinheiroPlayer -= precoAtual;
			levelAtual++;
			PlayerPrefs.SetInt (atributo,levelAtual);
			PlayerPrefs.SetInt ("gold",dinheiroPlayer);
			bars [levelAtual-1].SetActive (true);
			precoAtual = 10 * (int) Mathf.Pow (3, levelAtual);
			preco.text = "$ " + precoAtual.ToString();
			if (levelAtual >= 8) {
				preco.text = "MAX";
			}
		}
	}


}
