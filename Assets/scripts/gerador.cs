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
		if (count == 50) {
			Rigidbody2D instance;
			instance = Instantiate (rigidBodyPrefab) as Rigidbody2D;
			Vector2 positionRespaw = instance.position;
			positionRespaw.y = player.cameraPos;
			instance.position = positionRespaw;
			instance.AddForce (new Vector3 (-player.velocidade*5, 0, 0));

			count = 0;
		}
	}
}
