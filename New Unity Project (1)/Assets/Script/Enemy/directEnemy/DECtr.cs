using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DECtr : MonoBehaviour {

	public float life;
	public float speed;
	public Transform target;
	public float range;
	public float shootcd;
	private float lasttime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(transform.position, target.position)<range)
		{
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);
			transform.
			transform.right = target.position - transform.position;
			shoot();
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
			transform.right = target.position - transform.position;
			shoot();
		}
	
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
	public void takedmg(int dmg)
	{
		life -= dmg;
		if (life <= 0)
		{

			GameObject.Destroy(this.gameObject);

		}

	}
}
