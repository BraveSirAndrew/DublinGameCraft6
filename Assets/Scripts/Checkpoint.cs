using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class Checkpoint : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		collider.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	
	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player")
			return;
		
		other.gameObject.GetComponent<Player> ().PrevCheckpoint = other.transform.position;
	}
}
