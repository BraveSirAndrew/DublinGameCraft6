using UnityEngine;

public class CameraFacingBillboard : MonoBehaviour
{
	public Camera Camera;

	void Update()
	{
		transform.LookAt(transform.position + Camera.transform.rotation * Vector3.forward, Camera.transform.rotation * Vector3.up);
	}
}