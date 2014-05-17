using UnityEngine;

public class CameraTrackPoint : MonoBehaviour
{
	public float HeightToDistanceScale;

	private GameObject _playerOne;
	private GameObject _playerTwo;
	private GameObject _camera;

	void Start ()
	{
		_playerOne = GameObject.Find("Player1/Body");
		_playerTwo = GameObject.Find("Player2/Body");
		_camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	void Update ()
	{
		var vectorBetweenPlayers = _playerTwo.transform.position - _playerOne.transform.position;
		transform.position = _playerOne.transform.position + vectorBetweenPlayers * 0.5f;

		_camera.GetComponent<SmoothFollow>().height = vectorBetweenPlayers.magnitude * HeightToDistanceScale;
	}
}
