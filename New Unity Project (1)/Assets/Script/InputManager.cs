using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	private float vertical;
	private float horizontal;
	private bool fire;
	private bool action1;
	private bool action2;
	private playerCtr ctr;
	// Use this for initialization
	void Start () {
		ctr = GetComponent<playerCtr>();
	}
	
	// Update is called once per frame
	void Update () {

		vertical = Input.GetAxis("Vertical");
		horizontal = Input.GetAxis("Horizontal");
		fire = Input.GetButton("Fire1");
		action1 = Input.GetButtonDown("Fire2");
		action2 = Input.GetButtonDown("Fire3");

		updateInputs();
	}


	void updateInputs()
	{
		ctr.ver = vertical;
		ctr.hor = horizontal;
		ctr.fire = fire;
		ctr.ac1 = action1;
		ctr.ac2 = action2;
	}
}
