using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEctr : MonoBehaviour {


	public int life;
	public float speed;
	public float shootcd;
	private int starlife;
	[SerializeField]
	private float lasttime ;
	// Use this for initialization
	void Start () {
		starlife = life;
		lasttime = Random.Range(0, 5);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0, -this.speed * Time.deltaTime, 0);
		shoot();
	}


	private void shoot()
	{
		if(Time.time - lasttime>shootcd)
		{
			GameObject b = Gamemanager.instance.poolenemy(1);
			b.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-1f, this.transform.position.z);
			b.SetActive(true);
			lasttime = Time.time;
		}
	
	}
	public void takedmg(int dmg)
	{
		life -= dmg;
		if(life<=0)
		{
			life = starlife;
			GameObject.Destroy(this.gameObject);
			
		}
	}
}
