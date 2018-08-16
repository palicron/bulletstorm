using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStartet : MonoBehaviour {


	public GameObject[] ships;
	private bool active = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (active || !other.gameObject.tag.Equals("StarTrigger"))
			return;
		for(int i=0;i<ships.Length;i++)
		{
			ships[i].SetActive(true);

		}
		active = true;
	}
}
