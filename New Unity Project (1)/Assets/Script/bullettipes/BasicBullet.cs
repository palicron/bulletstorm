using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : bullet {


	Renderer render;

	private void Start()
	{
		render = this.GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3(0, this.speed * Time.deltaTime, 0);
		if(!render.isVisible)
			this.gameObject.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		DmgCollider dmg = other.gameObject.GetComponent<DmgCollider>();
		if (dmg == null  || (other.gameObject.tag.Equals(this.shoottag)))
			return;

		dmg.takedmg(this.dmg);
		
		this.gameObject.SetActive(false);
	}


}
