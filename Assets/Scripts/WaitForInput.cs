using UnityEngine;
using System.Collections;

public class WaitForInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isControlerInput())
			Application.LoadLevel("HoverboardTogue");
	}

	private bool isControlerInput()
	{
		// joystick buttons
		if (Input.GetKey(KeyCode.Joystick1Button0) ||
		Input.GetKey(KeyCode.Joystick1Button1) ||
		Input.GetKey(KeyCode.Joystick1Button2) ||
		Input.GetKey(KeyCode.Joystick1Button3) ||
		Input.GetKey(KeyCode.Joystick1Button4) ||
		Input.GetKey(KeyCode.Joystick1Button5) ||
		Input.GetKey(KeyCode.Joystick1Button6) ||
		Input.GetKey(KeyCode.Joystick1Button7) ||
		Input.GetKey(KeyCode.Joystick1Button8) ||
		Input.GetKey(KeyCode.Joystick1Button9) ||
		Input.GetKey(KeyCode.Joystick1Button10) ||
		Input.GetKey(KeyCode.Joystick1Button11) ||
		Input.GetKey(KeyCode.Joystick1Button12) ||
		Input.GetKey(KeyCode.Joystick1Button13) ||
		Input.GetKey(KeyCode.Joystick1Button14) ||
		Input.GetKey(KeyCode.Joystick1Button15) ||
		Input.GetKey(KeyCode.Joystick1Button16) ||
		Input.GetKey(KeyCode.Joystick1Button17) ||
		Input.GetKey(KeyCode.Joystick1Button18) ||
		Input.GetKey(KeyCode.Joystick1Button19))
		{
			return true;
		}

		if (Input.GetKey(KeyCode.JoystickButton0) ||
		Input.GetKey(KeyCode.JoystickButton1) ||
		Input.GetKey(KeyCode.JoystickButton2) ||
		Input.GetKey(KeyCode.JoystickButton3) ||
		Input.GetKey(KeyCode.JoystickButton4) ||
		Input.GetKey(KeyCode.JoystickButton5) ||
		Input.GetKey(KeyCode.JoystickButton6) ||
		Input.GetKey(KeyCode.JoystickButton7) ||
		Input.GetKey(KeyCode.JoystickButton8) ||
		Input.GetKey(KeyCode.JoystickButton9) ||
		Input.GetKey(KeyCode.JoystickButton10) ||
		Input.GetKey(KeyCode.JoystickButton11) ||
		Input.GetKey(KeyCode.JoystickButton12) ||
		Input.GetKey(KeyCode.JoystickButton13) ||
		Input.GetKey(KeyCode.JoystickButton14) ||
		Input.GetKey(KeyCode.JoystickButton15) ||
		Input.GetKey(KeyCode.JoystickButton16) ||
		Input.GetKey(KeyCode.JoystickButton17) ||
		Input.GetKey(KeyCode.JoystickButton18) ||
		Input.GetKey(KeyCode.JoystickButton19))
		{
			return true;
		}

		return false;
	}
}
