﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	private float y;
	// Use this for initialization
	void Start () {
		y = 0;
	}

	// Update is called once per frame
	void Update () {
		y = player.cameraPos;
		y /= 1.1f;

		if (y < 0)
			y = 0;
		transform.position = new Vector3 (0,y,-10);
	}
}
