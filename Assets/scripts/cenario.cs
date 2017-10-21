using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenario : MonoBehaviour {
	
	private float offset;
	private Material materialAtual;

	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer> ().material;
		offset = 0;
		materialAtual.SetTextureOffset ("_MainTex", new Vector2 (offset, 0));
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (player.offsetMap) {
			offset += (player.velocidade / 1000);
			player.velocidade -= 0.01f;
			if (player.velocidade <= 10)
				player.velocidade = 0;

			materialAtual.SetTextureOffset ("_MainTex", new Vector2 (offset, 0));
		}
	}
}
