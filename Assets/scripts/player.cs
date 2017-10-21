using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private Rigidbody2D playerRB;
	//private SpriteRenderer playerSR;

	static public float velocidade;
	static public bool offsetMap;
	static public float cameraPos;
	private float bounce;

	// Use this for initialization
	void Start () {
		//velocidade = 100f;
		offsetMap = false; 
		bounce = 40;
		playerRB = GetComponent<Rigidbody2D>();
		//playerSR = GetComponent<SpriteRenderer>();
		playerRB.AddForce(new Vector2(velocidade*20,velocidade*20),ForceMode2D.Force); 
		playerRB.AddTorque (velocidade*-3);

	}


	void FixedUpdate()
	{
		cameraPos = playerRB.position.y;
		Vector3 v = playerRB.velocity;
		if (v.x !=0 && playerRB.position.x >= (-5)) {
			v.x /= 1.3f;
			playerRB.velocity = v;
			offsetMap = true;

		}

		if (playerRB.position.x > (-3.5)) {
			playerRB.AddForce(new Vector2(-1.3f,0),ForceMode2D.Force); 
		}
		else if (playerRB.position.x < (-3.5)) {
			playerRB.AddForce(new Vector2(1.3f,0),ForceMode2D.Force); 
		}	
	}

	void OnCollisionEnter2D(Collision2D colisao) {
		if (colisao.gameObject.tag == "floor") {
			
			playerRB.AddForce(new Vector2(0,(velocidade/3)*bounce),ForceMode2D.Force); 
			playerRB.AddTorque (velocidade*-3);
			player.velocidade -= 1f;

		}
	}
}
