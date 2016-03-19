﻿using UnityEngine;
using UnityEngine.Networking;

public class PlayerMannager : NetworkBehaviour {

	[SerializeField]
	private int maxHealth = 100;

	[SyncVar]
	private int currentHealth;

	void Awake(){
		SetDefault ();
	}

	public void TakeDamage(int _amount){
		currentHealth -= _amount;

		Debug.Log (transform.name + " now has " + currentHealth + " health");
	}

	public void SetDefault(){
		currentHealth = maxHealth;
	}
}