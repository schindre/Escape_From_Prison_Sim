using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour {



	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("restart");
		if (other.gameObject.tag == "mine" ) 
		{
			SceneManager.LoadScene ("DeathScene");
		}
		if (other.gameObject.tag == "BadDog") 
		{
			SceneManager.LoadScene ("DeathScene");	
		}
	}
}
