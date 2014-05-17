using UnityEngine;
using System.Collections;

public class BouncyThing : MonoBehaviour
{

	public float Bounciness;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
		var direction = collision.rigidbody.velocity.normalized;
		var mag = collision.rigidbody.velocity.magnitude;
		collision.rigidbody.AddForce(Vector3.Reflect(direction, collision.contacts[0].normal) * mag * Bounciness, ForceMode.Impulse);
	}
}
