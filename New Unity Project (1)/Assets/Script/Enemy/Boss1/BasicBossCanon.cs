using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBossCanon : BossWeapon {

	public Transform target;
	public float shootcd;
	private float lasttime;
	private Renderer ren;
	// Use this for initialization
	void Start()
	{
		ren = this.GetComponentInChildren<Renderer>();
		lasttime = Random.Range(0, 5);
	}
	// Update is called once per frame
	void Update() {
		if (!ren.isVisible)
			return;

		
		transform.right = (target.position - transform.position);
		shoot();
	}

	private void shoot()
	{
		if (Time.time - lasttime > shootcd)
		{
			Vector3 dic = (target.position - transform.position).normalized;
			GameObject b = Gamemanager.instance.pooldirect();
			b.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z);
			b.GetComponent<DirectionalBullert>().forwar = dic;
			b.SetActive(true);
			lasttime = Time.time;
		}

	}
	public override void makedmg(int dmg)
	{
		life -= dmg;
		if(life<=0)
		{
			parent.GetComponent<ColosoCtr>().takedmg(this.dmgToParent);
			GameObject.Destroy(this.gameObject);
		}
	}
}
