﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float zSpeed = 0.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {
		transform.Translate (zSpeed, 0, 0);
	}
}
