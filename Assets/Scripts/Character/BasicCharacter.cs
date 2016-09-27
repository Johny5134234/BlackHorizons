﻿using UnityEngine;
using System.Collections;
public class BasicCharacter : MonoBehaviour {
	public float moveSpeed;
	public float jumpHeight;

	float jumpCount = 0;
	public float maxJumps = 2;

	// Use this for initialization
	void Start () {
	}

	void fixedUpdate() {

	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.tag == "GROUND") {
			jumpCount = 0;
		}	
	}

	// Update is called once per frame
	void Update () {
		Rigidbody2D characterRigidBody = GetComponent<Rigidbody2D>();
		if (Input.GetKeyDown (KeyCode.Space) && jumpCount < maxJumps) {
			characterRigidBody.AddForce(new Vector2D(characterRigidBody.velocity.x, jumpHeight));
			jumpCount += 1;
		}
		if (Input.GetKey (KeyCode.D)) {
			characterRigidBody.AddForce(new Vector2D(moveSpeed, characterRigidBody.velocity.y));
		}
		if (Input.GetKey (KeyCode.A)) {
			characterRigidBody.velocity = new Vector2 (-moveSpeed, characterRigidBody.velocity.y);
		}
	}
