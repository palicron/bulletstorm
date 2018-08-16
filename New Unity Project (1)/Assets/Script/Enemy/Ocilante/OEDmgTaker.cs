using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OEDmgTaker : DmgCollider {

	private OECtr ctr;
	// Use this for initialization
	void Start () {
		ctr = this.GetComponent<OECtr>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public override void takedmg(int dmg)
	{
		ctr.takedmg(dmg);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.GetComponent<DmgCollider>().takedmg(this.crashdmg);
		}
	}
}
