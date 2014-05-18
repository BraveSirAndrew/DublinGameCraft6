using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector3 PrevCheckpoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DieAsshole()
	{
		transform.position = PrevCheckpoint;
		rigidbody.velocity = Vector3.zero;
	}
}
