﻿using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour
{

	public GameObject playerPrefab;
	GameObject playerInstance;

	float respawnTimer;

	// Use this for initialization
	void Start()
	{
		SpawnPlayer();
	}

	void SpawnPlayer()
	{
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}

	// Update is called once per frame
	void Update()
	{
	}

}
