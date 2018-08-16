using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DmgCollider : MonoBehaviour {
	public int inviframes;
	public int crashdmg;
	
	public abstract void takedmg(int dmg);
}
