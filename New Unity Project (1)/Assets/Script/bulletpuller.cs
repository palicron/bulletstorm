using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletpuller : MonoBehaviour {

	 
	public GameObject basicbullet;
	public GameObject Ebasic;
	public GameObject dicBullet;
	public GameObject Emisil;
	public GameObject[] basicbulletsPlayer;
	public GameObject[] EnemyBasciBullet;
	public GameObject[] EnemyDirecBullet;
	public GameObject[] EnemyMisil;
	private int cont1;
	private int cont2;
	private int cont3;
	private int cont4;
	// Use this for initialization
	void Start () {
		cont1 = 0;
		//contador de basica de enemigos
		cont2 = 0;

		cont3 = 0;

		cont4 = 0;
		//intacia las balas basicas del juaggador
		for (int i=0;i< basicbulletsPlayer.Length;i++ )
		{
			basicbulletsPlayer[i] = GameObject.Instantiate(basicbullet, Vector3.zero,Quaternion.identity);
			basicbulletsPlayer[i].transform.parent = this.transform;
			basicbulletsPlayer[i].GetComponent<bullet>().shoottag = "Player";
			basicbulletsPlayer[i].SetActive(false);
		}
		//intacia balas basicas enemigos
		for (int i = 0; i < EnemyBasciBullet.Length; i++)
		{
			EnemyBasciBullet[i] = GameObject.Instantiate(Ebasic, Vector3.zero, Quaternion.identity);
			EnemyBasciBullet[i].transform.parent = this.transform;
			EnemyBasciBullet[i].GetComponent<bullet>().shoottag = "Enemy";
			EnemyBasciBullet[i].SetActive(false);
		}
		//inicanliza la bala dirigida
		for (int i = 0; i < EnemyDirecBullet.Length; i++)
		{
			EnemyDirecBullet[i] = GameObject.Instantiate(dicBullet, Vector3.zero, Quaternion.identity);
			EnemyDirecBullet[i].transform.parent = this.transform;
			EnemyDirecBullet[i].GetComponent<bullet>().shoottag = "Enemy";
			EnemyDirecBullet[i].SetActive(false);
		}
		for (int i = 0; i < EnemyMisil.Length; i++)
		{
			EnemyMisil[i] = GameObject.Instantiate(Emisil, Vector3.zero, Quaternion.identity);
			EnemyMisil[i].transform.parent = this.transform;
			EnemyMisil[i].GetComponent<bullet>().shoottag = "Enemy";
			EnemyMisil[i].SetActive(false);
		}
		
	}

	private void Awake()
	{
		GameObject.DontDestroyOnLoad(this);
	}
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject poolbasicbullet()
	{
		cont1++;
		if (cont1 > basicbulletsPlayer.Length-1)
			cont1 = 0;
		return basicbulletsPlayer[cont1];		
	}
	public GameObject poolEB()
	{
		cont2++;
		if (cont2 > EnemyBasciBullet.Length - 1)
			cont2 = 0;
		return EnemyBasciBullet[cont2];
	}

	public GameObject poolDB()
	{
		cont3++;
		if (cont3 > EnemyDirecBullet.Length - 1)
			cont3 = 0;
		 
		return EnemyDirecBullet[cont3];

	}
	public GameObject poolMis()
	{
		cont4++;
		if (cont4 > EnemyMisil.Length - 1)
			cont4 = 0;

		return EnemyMisil[cont4];

	}
}
