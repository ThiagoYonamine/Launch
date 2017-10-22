using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {


	// Use this for initialization
	void Start () {

		//SUPER LEMBRAR DE APAGAR ESSA LINHA!!! linha para debug
		PlayerPrefs.SetInt ("first", 0);
		//^^^^^^^^APAGAR^^^^ PARA NÃO RESETAR


		if (PlayerPrefs.GetInt ("first")==0) {
			
			PlayerPrefs.SetInt ("first", 1);
			PlayerPrefs.SetInt ("gold", 0);
		    PlayerPrefs.SetInt ("bounce", 200);
			PlayerPrefs.SetInt ("debounce", 20);
			PlayerPrefs.SetInt ("aerodynamics", 100);
			PlayerPrefs.SetInt ("power", 1);

			print ("first");
		
		}

	}
	

}
