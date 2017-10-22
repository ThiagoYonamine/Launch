using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour {
	public Text txtGold;
	// Use this for initialization
	void Start () {
		txtGold.text = "Gold: " + PlayerPrefs.GetInt("gold").ToString();
	}
	

}
