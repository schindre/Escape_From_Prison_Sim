using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) 
		{
			Application.LoadLevel ("Scene 1");
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("restart");
		if (other.gameObject.tag == "mine") 
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "BadDog") 
		{
			Destroy(gameObject);
		}
	}
}
