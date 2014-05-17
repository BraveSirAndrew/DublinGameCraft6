using System.Collections;
using UnityEngine;

public class ReverseControlsRegion : MonoBehaviour
{
	private Collider _collider;
	private Coroutine _countDownTimer;
	private bool _coroutineRunning;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter(Collider collider)
	{
		_collider = collider;
		StopCoroutine("CountdownTimer");
		foreach (var componentsInChild in collider.GetComponentsInChildren<Thruster>())
		{
			componentsInChild.ControlsReversed = true;
		}

		if (_coroutineRunning == false)
			_countDownTimer = StartCoroutine("CountdownTimer");
	}

	private IEnumerator CountdownTimer()
	{
		_coroutineRunning = true;
		yield return new WaitForSeconds(10);

		foreach (var componentsInChild in _collider.GetComponentsInChildren<Thruster>())
		{
			componentsInChild.ControlsReversed = false;
		}

		_coroutineRunning = false;
	}
}
