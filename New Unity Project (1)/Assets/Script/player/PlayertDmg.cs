using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayertDmg : DmgCollider {

	private playerCtr ctr;

	public override void takedmg(int dmg)
	{
		ctr.takedmg(dmg);
	}

	// Use this for initialization
	void Start () {
		ctr = this.GetComponent<playerCtr>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Enemy"))
		{
			other.gameObject.GetComponent<DmgCollider>().takedmg(crashdmg);
		}
	}
}
