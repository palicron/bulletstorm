using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEdmgTaker : DmgCollider {


	private BEctr ctr;


	public override void takedmg(int dmg)
	{
		ctr.takedmg(dmg);
	}

	// Use this for initialization
	void Start () {
		ctr = this.GetComponent<BEctr>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.GetComponent<DmgCollider>().takedmg(this.crashdmg);
		}
	}
}
