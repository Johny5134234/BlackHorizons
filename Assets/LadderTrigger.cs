﻿using UnityEngine;
using System.Collections;

public class LadderTrigger : MonoBehaviour {

	public float ladderMoveSpeed = 0.15;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		other.AddForce(new Vector2(other.velocity.x, ladderMoveSpeed));
	}

	// Update is called once per frame
	void Update () {
	
	}
}
