
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(BoxCollider))]
public class FinishLine : MonoBehaviour {

	private Dictionary<GameObject, float> _crossingRecord;

	public int Laps;
	public float CurrentLap;

	// Use this for initialization
	void Start () {
		_crossingRecord = new Dictionary<GameObject, float> ();
		collider.isTrigger = true;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player")
			return;

		var direction = Mathf.Sign(transform.TransformDirection (other.rigidbody.velocity).z);
		var value = 0.5f * direction;

		if (_crossingRecord.ContainsKey (other.gameObject))
		{
			_crossingRecord [other.gameObject] += value;
		}
		else
		{
			_crossingRecord.Add (other.gameObject, value);
		}

		CurrentLap = _crossingRecord [other.gameObject];
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag != "Player")
			return;
		
		var direction = Mathf.Sign(transform.TransformDirection (other.rigidbody.velocity).z);
		var value = 0.5f * direction;
		
		if (_crossingRecord.ContainsKey (other.gameObject))
		{
			_crossingRecord [other.gameObject] += value;
		}
		else
		{
			_crossingRecord.Add (other.gameObject, value);
		}
		
		CurrentLap = _crossingRecord [other.gameObject];

		if (_crossingRecord [other.gameObject] >= Laps) {
			if(other.transform.parent.name == "Player1")
			{
				transform.Find("WinScreen1").gameObject.SetActive(true);
			}
			else
			{
				transform.Find("WinScreen2").gameObject.SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
