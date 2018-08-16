using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BossWeapon : MonoBehaviour {

	public int life;
	public int dmgToParent;
	public GameObject parent;

	public abstract void makedmg(int dmg);
}
