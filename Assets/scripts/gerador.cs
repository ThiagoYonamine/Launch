using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour {

	public Rigidbody2D rigidBodyCoin;
	public Rigidbody2D rigidBodyPig;
	private int timerCoin;
	private int timerPig;
	private int levelCoin;
	private int levelPig;
	void Start(){
		timerCoin = 0;
		timerPig = 0;
		levelCoin = PlayerPrefs.GetInt ("coin");
		levelPig = PlayerPrefs.GetInt ("pig");

	}

	bool gerar(int probability){
		float prob = Random.Range(0,50);
		bool r = prob <= probability;
		print (r);
		return r;
	}
	void FixedUpdate () {
		timerCoin++;
		timerPig++;
		/*if (timerCoin >= 80/levelCoin) {

			if (gerar(levelCoin+1)) {
				Rigidbody2D instanceCoin;
				instanceCoin = Instantiate (rigidBodyCoin) as Rigidbody2D;
				Vector2 positionRespaw = instanceCoin.position;
				float variancia = Random.Range (-5, 5);
				float posY = player.cameraPos + variancia;
				if (posY < 0)
					posY = 0;
				positionRespaw.y = posY;
				instanceCoin.position = positionRespaw;
				instanceCoin.AddForce (new Vector3 (-30 - (player.velocidade * 5), 0, 0));
				timerCoin = 0;
			}
		}*/

		double pigRespaw = (levelPig*1.0 / 2.0);

		if (timerPig >= 200/pigRespaw) {

			if (gerar (levelPig)) {
				print ("gerando");
				Rigidbody2D instancePig;
				instancePig = Instantiate (rigidBodyPig) as Rigidbody2D;
				Vector2 positionRespaw = instancePig.position;
				positionRespaw.x = 9.44f;
				instancePig.position = positionRespaw;
				instancePig.AddForce (new Vector3 (-50 - (player.velocidade), 0, 0));
				timerPig = 0;
			}
		}

	}
}
