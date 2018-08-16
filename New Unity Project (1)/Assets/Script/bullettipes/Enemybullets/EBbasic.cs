using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBbasic : bullet {


	// Update is called once per frame
	void Update()
	{

		transform.position += new Vector3(0, -this.speed * Time.deltaTime, 0);
	}

	private void OnTriggerEnter(Collider other)
	{
		DmgCollider dmg = other.gameObject.GetComponent<DmgCollider>();
		if (dmg == null || (other.gameObject.tag.Equals(this.shoottag)))
			return;

		dmg.takedmg(this.dmg);

		this.gameObject.SetActive(false);
	}
}
