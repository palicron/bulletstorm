using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeAndHealtCtr : MonoBehaviour {

	private static LifeAndHealtCtr _instance;
	public static LifeAndHealtCtr instance
	{
		get
		{
			if (_instance == null)
			{
				
				GameObject go = new GameObject("LifeAndHealtCtr");
				go.AddComponent<LifeAndHealtCtr>();

			}
			return _instance;
		}
		
	}
	public Image[] healt;
	public Text life;
	// Use this for initialization

	private void Awake()
	{
		_instance = this;
	}

	
	public void updatelife(int lf)
	{
		this.life.text = lf.ToString();
	}

	public void updatehealt(int he)
	{
		if (he < 0)
			he = 0;
		for(int i =0;i<he;i++)
		{
			healt[i].gameObject.SetActive(true);
		}
		for(int k =he;k<healt.Length;k++)
		{
			healt[k].gameObject.SetActive(false);
		}
	}
}
