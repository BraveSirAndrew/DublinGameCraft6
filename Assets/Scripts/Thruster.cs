using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour 
{
	public float _maxThrust;

	// Use this for initialization
	void Start () 
	{
	
	} 
	
	// Update is called once per frame
	void Update ()
	{
		transform.LookAt(transform.position + new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical") * -1));
		gameObject.transform.parent.rigidbody.AddForceAtPosition(
			new Vector3 (Input.GetAxis ("Horizontal") * -1 * _maxThrust, 0, Input.GetAxis ("Vertical") * _maxThrust), 
			transform.position);


	}


}
