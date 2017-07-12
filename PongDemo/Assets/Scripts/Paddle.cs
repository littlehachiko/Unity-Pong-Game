using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	public float paddleSpeed = 1.0f;
	public Vector3 playerPos = new Vector3(0,0,0);

	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")* paddleSpeed);
		playerPos = new Vector3 (-5, Mathf.Clamp (yPos, -4, 4), 0);
		gameObject.transform.position = playerPos;
	}
}
