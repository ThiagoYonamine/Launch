using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour {


	// Use this for initialization
	void Start () {

		//SUPER LEMBRAR DE APAGAR ESSA LINHA!!! linha para debug
		PlayerPrefs.DeleteAll();
		PlayerPrefs.SetInt ("first", 0);
		//^^^^^^^^APAGAR^^^^ PARA NÃO RESETAR


		if (PlayerPrefs.GetInt ("first")==0) {
			
			PlayerPrefs.SetInt ("first", 1);
			PlayerPrefs.SetInt ("gold", 100000);

		    

			//cow
			PlayerPrefs.SetInt ("bounce", 200);
			PlayerPrefs.SetInt ("aerodynamics", 100);

			//friendly
			PlayerPrefs.SetInt ("coin", 8);
			PlayerPrefs.SetInt ("pig", 1);

			//Launch
			PlayerPrefs.SetInt ("power", 8);
			PlayerPrefs.SetInt ("powerLaunch", 10);

			print ("first");
		
		}

	}
	

}
