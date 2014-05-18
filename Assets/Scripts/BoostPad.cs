using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class BoostPad : MonoBehaviour 
{
	public float Force;
	public Vector3 Direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		var thrusters = GameObject.FindGameObjectsWithTag ("Thruster");
		var direction = transform.TransformDirection(Direction);

		foreach (var thruster in thrusters) 
		{
			if(!PadContainsObject(thruster.transform.position))
			   continue;
			  
			thruster.transform.parent.rigidbody.AddForceAtPosition(direction * Force, thruster.transform.position);
		}
	}

	private bool PadContainsObject(Vector3 position)
	{
		return collider.bounds.Contains(position);
	}
}
