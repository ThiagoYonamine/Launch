﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class launch : MonoBehaviour {

	public void launchJogo(){
		player.velocidade = 15f;
		SceneManager.LoadScene ("jogo", LoadSceneMode.Single);
	}

}