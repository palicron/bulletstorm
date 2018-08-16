using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtr : MonoBehaviour {


	public float ver;
	public float hor;
	public bool fire;
	public bool ac1;
	public bool ac2;
	public float speed;
	public int life;
	public int bombs;
	private Transform trans;
	public float firecd;
	private float lasttime =0;
	private int starlife;
	public Camera mc;
	[SerializeField]
	private string tag;
	// Use this for initialization
	void Start () {
		trans = this.GetComponent<Transform>();
		tag = this.gameObject.tag;
		starlife = life;
		LifeAndHealtCtr.instance.updatehealt(life);

	}
	
	// Update is called once per frame
	void Update () {
		move();
		action();
	}


	void move()
	{
		Vector3 next =trans.position + new Vector3(speed * hor * Time.deltaTime, speed*ver*Time.deltaTime,0);
		Vector3 toview = mc.WorldToViewportPoint(next);
		if (toview.y > 1 || toview.y < 0)
			next.y = trans.position.y;
		if (toview.x > 1 || toview.x < 0)
			next.x = trans.position.x;
		trans.position = next;




	}

	void action()
	{
		if(fire)
		{
			if(Time.time - lasttime>firecd)
			{
				GameObject b = Gamemanager.instance.poolplayer(1);
				b.transform.position = new Vector3(this.trans.position.x, this.trans.position.y+1f,0);
				
				b.SetActive(true);
				lasttime = Time.time;
			}
		
		}
	}

	public void takedmg(int dmg)
	{
		life -= dmg;
		LifeAndHealtCtr.instance.updatehealt(life);
		if (life<=0)
		{
			life = starlife;
			Gamemanager.instance.respwand(this.gameObject);
			
		}

	}

	
}
