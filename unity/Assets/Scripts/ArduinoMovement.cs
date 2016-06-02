using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoMovement : MonoBehaviour {
	
	SerialPort stream = new SerialPort("COM4", 115200); // Defines the serial port and the speed

	void Start () {
		stream.Open(); // Opens the serial port
	}

	void Update () {
		print (stream.ReadLine ());
		string streamInput = stream.ReadLine(); // Reads the data from the arduino card
		string[] gyroPosition = streamInput.Split(','); // Splits the data from the arduino card so that we have values to work with

		// Rotation. Makes the platform moves smoothly towards a target (the value from the arduino card)
		Quaternion target = Quaternion.Euler(float.Parse(gyroPosition[0]),float.Parse(gyroPosition[1]),float.Parse(gyroPosition[2]));
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 2.0f);

	}


}