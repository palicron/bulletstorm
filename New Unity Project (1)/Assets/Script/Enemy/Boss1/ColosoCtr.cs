using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColosoCtr : MonoBehaviour {

	public float life;
	private float starlife;
	private int fase = 1;
	public GameObject seconface;


	private void detro()
	{
		GameObject.Destroy(this.gameObject);
	}
	private void starseconfase()
	{
		seconface.SetActive(true);
	}
	public void takedmg(int dmg)
	{
		life -= dmg;
		if (life <= 0)
		{
			Invoke("detro", 1);
		}
		if (life == 4)
		{
			starseconfase();
		}

	}
}
