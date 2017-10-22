using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour {

	public Rigidbody2D rigidBodyPrefab;
	private int count;
	void Start(){
		count = 0;
	}
	void FixedUpdate () {
		count++;
		if (count == 20) {
			Rigidbody2D instance;
			instance = Instantiate (rigidBodyPrefab) as Rigidbody2D;
			Vector2 positionRespaw = instance.position;
			float variancia = Random.Range(-5,5);
			float posY = player.cameraPos + variancia;
			if (posY < 0)
				posY = 0;
			positionRespaw.y = posY;
			instance.position = positionRespaw;
			instance.AddForce (new Vector3 (-30 -(player.velocidade*5), 0, 0));

			count = 0;
		}
	}
}
