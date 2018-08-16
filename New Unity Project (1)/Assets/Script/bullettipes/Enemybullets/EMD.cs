using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMD : bullet {

	Renderer render;
	public Transform target;
	public int life;
	private int starlife;
	private void Start()
	{
		starlife = life;
		//render = this.GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 dd = target.position;
		dd.z = 0;
		transform.position =  Vector3.MoveTowards(transform.position, dd, speed*Time.deltaTime );

		transform.right = (target.position - transform.position);
		//transform.position += new Vector3(0, this.speed * Time.deltaTime, 0);
	//	if (!render.isVisible)
			//this.gameObject.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		DmgCollider dmg = other.gameObject.GetComponent<DmgCollider>();
		if (dmg == null || (other.gameObject.tag.Equals(this.shoottag)))
			return;

		dmg.takedmg(this.dmg);

		starlife = life;
		this.gameObject.SetActive(false);
	}
	 public void takedmg(int dmg)
	{
		life -= dmg;
		if(life<=0)
		{
			starlife = life;
			this.gameObject.SetActive(false);
		}
	}

}
