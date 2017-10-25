using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchAnimation : MonoBehaviour {
	private Animator playerAnimator;
	// Use this for initialization
	void Start () {
		playerAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			playerAnimator.SetBool ("click", true);
		}
		else if (Input.GetMouseButtonUp(0))
		{
			playerAnimator.SetBool ("click", false);
		}
	}
}
