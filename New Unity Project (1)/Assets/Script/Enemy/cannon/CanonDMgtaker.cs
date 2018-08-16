using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonDMgtaker : DmgCollider {

	private CannonCtr ctr;


	public override void takedmg(int dmg)
	{
		ctr.takedmg(dmg);
	}

	// Use this for initialization
	void Start()
	{
		ctr = this.GetComponent<CannonCtr>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.GetComponent<DmgCollider>().takedmg(this.crashdmg);
		}
	}
}
