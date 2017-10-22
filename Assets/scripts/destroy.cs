using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
	private Rigidbody2D objRB;

	// Use this for initialization
	void Start () {
		
		objRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (objRB.position.x <= -15) {
			Destroy (gameObject);
		}
	}
}
