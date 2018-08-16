using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilDmgtaker : DmgCollider {


	private EMD ctr;
	public override void takedmg(int dmg)
	{
		ctr.takedmg(dmg);
	}

	// Use this for initialization
	void Start () {
		ctr = this.GetComponent<EMD>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
