using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class launch : MonoBehaviour {

	private float click;
	private int timer;
	private bool start;
	private float power;
	private int powerLaunch;

	public void count(){
		start = true;
		click += 1;

	}

	public void launchJogo(){
		
		player.velocidade = 40+powerLaunch+(click*power);
		print (player.velocidade);
		SceneManager.LoadScene ("jogo", LoadSceneMode.Single);
	}


	void Start(){
		timer = 0;
		click = 0;
		power = PlayerPrefs.GetFloat ("power");
		powerLaunch = PlayerPrefs.GetInt ("powerLaunch");
		start = false;
	
	}
	void FixedUpdate(){
		
		if (start) {
			timer++;
			if (timer >= 100)
				launchJogo ();
		}
	}

}
