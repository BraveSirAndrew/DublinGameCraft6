﻿using UnityEngine;
using System.Collections;

public class DeathBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player")
			return;
		
		other.gameObject.GetComponent<Player> ().DieAsshole ();
	}
}
