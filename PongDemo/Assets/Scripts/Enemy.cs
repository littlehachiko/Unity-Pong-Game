using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 8;
	Vector3 targetPos;
	GameObject ballObject;

	void Start () {
		ballObject = GameObject.FindGameObjectWithTag("Ball");
	}

	void Update () {
		targetPos = Vector3.Lerp (transform.position, ballObject.transform.position, Time.deltaTime * speed);
		transform.position = new Vector3 (8, targetPos.y, 0);
	}
}
