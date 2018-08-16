using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDmgtaker : DmgCollider {

	private BasicBossCanon ctr;
	// Use this for initialization
	void Start () {
		ctr = this.GetComponent<BasicBossCanon>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void takedmg(int dmg)
	{
		ctr.makedmg(dmg);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.GetComponent<DmgCollider>().takedmg(this.crashdmg);
		}
	}
}
