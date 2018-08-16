using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {


	private static Gamemanager _instance;

	public static Gamemanager instance
	{
		get
		{
			if(_instance == null)
			{
				GameObject go = new GameObject("GameManager");
				go.AddComponent<Gamemanager>();
			}
			return _instance;
		}
	}
	public int playerlife;
	public bulletpuller playerpool;
	public Transform spwanpoint;
	
	private void Awake()
	{
		_instance = this;
		GameObject.DontDestroyOnLoad(this);
		
	}

	private void Start()
	{
		LifeAndHealtCtr.instance.updatelife(playerlife);
	}

	public GameObject poolplayer(int type)
	{
		if (type == 1)
			return playerpool.poolbasicbullet();

		return null;
	}

	public GameObject poolenemy(int type)
	{
		if (type == 1)
			return playerpool.poolEB();
		if (type == 2)
			return playerpool.poolMis();
		return null;
	}
	public GameObject pooldirect()
	{
		
			return playerpool.poolDB();

		
	}

	public void respwand(GameObject player)
	{
		player.SetActive(false);
		playerlife--;
		LifeAndHealtCtr.instance.updatelife(playerlife);
		if (playerlife < 0)
			return;
		StartCoroutine(moveplayer(player));
		
	}

	private IEnumerator moveplayer(GameObject player)
	{
		yield return new WaitForSeconds(2);
		LifeAndHealtCtr.instance.updatehealt(player.GetComponent<playerCtr>().life);
		player.transform.position = spwanpoint.position;
		player.SetActive(true);
	}
}
