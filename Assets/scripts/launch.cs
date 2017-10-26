using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class launch : MonoBehaviour {

	private float click;
	private int timer;
	private bool start;
	private int power;
	private int powerLaunch;

	public void count(){
		start = true;
		click += 1;

	}
	public void moveIntro(){

		SceneManager.LoadScene ("launch", LoadSceneMode.Single);
	}

	public void moveUpgrade(){

		SceneManager.LoadScene ("upgrade", LoadSceneMode.Single);
	}

	public void launchJogo(){
		
		player.velocidade = powerLaunch+(click*power);
		print (player.velocidade);
		SceneManager.LoadScene ("jogo", LoadSceneMode.Single);
	}


	void Start(){
		timer = 0;
		click = 0;
		power = PlayerPrefs.GetInt ("power");
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
