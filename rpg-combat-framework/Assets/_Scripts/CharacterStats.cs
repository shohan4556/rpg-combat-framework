using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

	public int currentDamage;
	public float currentResistance;
	
	// Use this for initialization
	void Start () {
		
	}

	public int GetDamage(){
		return currentDamage;
	}

	public float GetResistance(){
		return currentResistance;
	}
}
