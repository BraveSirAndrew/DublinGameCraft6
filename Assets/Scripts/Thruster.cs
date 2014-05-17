using UnityEngine;

public class Thruster : MonoBehaviour 
{
	public float MaxThrust;
	public string HorizontalAxisName;
	public string VerticalAxisName;
	public float MaxParticleLifetime = 0.21f;

	void Start ()
	{
	
	}
	
	void Update ()
	{
		var stickDirection = new Vector3 (Input.GetAxis (HorizontalAxisName), 0, Input.GetAxis (VerticalAxisName) * -1);
		transform.LookAt(transform.position + stickDirection);
		gameObject.transform.parent.rigidbody.AddForceAtPosition(
			new Vector3(Input.GetAxis(HorizontalAxisName) * -1 * MaxThrust, 0, Input.GetAxis(VerticalAxisName) * MaxThrust), 
			transform.position);
		particleSystem.startLifetime = MaxParticleLifetime * stickDirection.magnitude;

//		var stickDirection = new Vector3(Input.GetAxis(HorizontalAxisName), 0, Input.GetAxis(VerticalAxisName) * -1) * MaxThrust;
//		transform.LookAt(transform.position + transform.parent.transform.TransformDirection(stickDirection));
//		stickDirection.z *= -1;
//		gameObject.transform.parent.rigidbody.AddForceAtPosition(
//		transform.parent.transform.TransformDirection(stickDirection),
//		transform.position);
//		particleSystem.startLifetime = MaxParticleLifetime * stickDirection.magnitude;
	}
}
