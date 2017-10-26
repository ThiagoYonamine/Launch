using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	public GameObject particula;
	private Rigidbody2D playerRB;
	//private SpriteRenderer playerSR;

	static public float velocidade;
	static public bool offsetMap;
	static public float cameraPos;
	private int bounce;
	private int debounce;
	private int aerodynamics;
	private int gold;
	private int valueCoin;
	// Use this for initialization
	void Start () {
		//velocidade = 100f;
		offsetMap = false; 
		bounce = PlayerPrefs.GetInt("bounce");
		debounce = 20;
		aerodynamics = PlayerPrefs.GetInt("aerodynamics");
		gold = PlayerPrefs.GetInt("gold");
		valueCoin = PlayerPrefs.GetInt("coin");
		playerRB = GetComponent<Rigidbody2D>();
		//playerSR = GetComponent<SpriteRenderer>();
		playerRB.AddForce(new Vector2(velocidade*20,velocidade*20),ForceMode2D.Force); 
		playerRB.AddTorque (velocidade*-10);

	}


	void FixedUpdate()
	{
		cameraPos = playerRB.position.y;
		//Vector3 v = playerRB.velocity;
		/*if (v.x !=0 && playerRB.position.x >= (-5)) {
			v.x /= 1.3f;
			playerRB.velocity = v;
			offsetMap = true;

		}

		if (playerRB.position.x > (-3.5)) {
			playerRB.AddForce(new Vector2(-1.3f,0),ForceMode2D.Force); 
		}
		else if (playerRB.position.x < (-3.5)) {
			playerRB.AddForce(new Vector2(1.3f,0),ForceMode2D.Force); 
		}*/
		Vector2 pos = playerRB.position;
		pos.x = -3.5f;
		playerRB.position = pos;

		//resistencia do ar
		float resistencia = 1.0f/aerodynamics*1.0f;
		player.velocidade -= resistencia;

		//volta para o menu
		if (player.velocidade <= 1 && playerRB.position.y <= -4.74) {
			player.velocidade = 0;
			PlayerPrefs.SetInt ("gold",gold);
			SceneManager.LoadScene ("launch", LoadSceneMode.Single);
		}
			

	}

	void OnCollisionStay2D(Collision2D colisao) {
		if (colisao.gameObject.tag == "floor") {
			//mudar animação
			print ("xao");
			playerRB.AddForce(new Vector2(0,10+bounce),ForceMode2D.Force);
			playerRB.AddTorque (velocidade*-0.5f);
			player.velocidade -= (debounce/10);

		}
	}

	void OnCollisionEnter2D(Collision2D colisao) {
		if (colisao.gameObject.tag == "floor") {
			playerRB.AddForce(new Vector2(0,10+bounce),ForceMode2D.Force);
			bounce -= debounce;

		}

		if (colisao.gameObject.tag == "coin") {
			gold += valueCoin;
			playerRB.AddTorque(-1);
			Destroy (colisao.gameObject);
		}

		if (colisao.gameObject.tag == "pig") {
			Destroy (colisao.gameObject);
			player.velocidade += 1f;
			playerRB.velocity = new Vector2 (0, 0);
			playerRB.AddForce(new Vector2(0,bounce*2),ForceMode2D.Force); 
			playerRB.AddTorque (velocidade*-1);

			Vector3 position = playerRB.transform.position;
			position.x -= 1;
			position.z -= 3;
			Instantiate (particula, position,  Quaternion.identity);

		}
	}

	
}
