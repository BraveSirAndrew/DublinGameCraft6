using UnityEngine;

public class Thruster : MonoBehaviour 
{
	public float MaxThrust;
	public string HorizontalAxisName;
	public string VerticalAxisName;
	public float MaxParticleLifetime = 0.21f;

	public bool ControlsReversed { get; set; }

	void Start ()
	{
		
	}
	
	void Update ()
	{
		var reversy = 1;
		if (ControlsReversed)
			reversy = -1;

		var stickDirection = new Vector3(Input.GetAxis(HorizontalAxisName) * reversy, 0, Input.GetAxis(VerticalAxisName) * -1 * reversy);
		transform.LookAt(transform.position + stickDirection);
		gameObject.transform.parent.rigidbody.AddForceAtPosition(
			new Vector3(Input.GetAxis(HorizontalAxisName) * -1 * MaxThrust * reversy, 0, Input.GetAxis(VerticalAxisName) * MaxThrust * reversy), 
			transform.position);
		particleSystem.startLifetime = MaxParticleLifetime * stickDirection.magnitude;
	}
}
