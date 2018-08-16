using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public float speed;
	public bool move;
	public bool moveleft;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(move)
		transform.position += new Vector3(0, speed * Time.deltaTime,0);
		if(moveleft)
			transform.position += new Vector3( speed * Time.deltaTime, 0,0);
	}
}
