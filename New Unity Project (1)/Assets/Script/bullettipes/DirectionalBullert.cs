using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalBullert : bullet {


	public Vector3 forwar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3(forwar.x,forwar.y,0)  * speed * Time.deltaTime;
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
