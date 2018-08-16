using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OECtr : MonoBehaviour {

	public float speed;
	public int life;
	public float aplitud;
	public float shootcd;
	private float lasttime;

	// Use this for initialization
	void Start () {
		lasttime = Random.Range(0, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += new Vector3(aplitud*(Mathf.Sin(Time.time)  * Time.deltaTime), -this.speed * Time.deltaTime, 0);
		shoot();


	}

	private void shoot()
	{
		if (Time.time - lasttime > shootcd)
		{
			GameObject b = Gamemanager.instance.poolenemy(1);
			b.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1f, this.transform.position.z);
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
