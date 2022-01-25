using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	public float ballVelocity;
	private Vector3 ballPosition;
	public float boundary;

	void Start()        // Use this for initialization
	{
		ballPosition = gameObject.transform.position;       // get the initial position of the game object
	}

	void Update()       // Update is called once per frame
	{
		ballPosition.x += Input.GetAxis("Horizontal") * ballVelocity;       // horizontal movement

		transform.position = ballPosition;      // update the game object transform

		if (ballPosition.x < -boundary)     // boundaries
		{
			destroy(ball);
		}
		if (ballPosition.x > boundary)
		{
			destroy(ball);
		}
	}
}