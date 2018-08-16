using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despwaner : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.Equals("Enemy")|| other.gameObject.tag.Equals("Bullet"))
		other.gameObject.SetActive(false);
	}
}
