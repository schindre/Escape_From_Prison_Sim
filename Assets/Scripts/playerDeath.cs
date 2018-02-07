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
			Invoke ("ChangeLevel1", 0.3f);
		}
		if (other.gameObject.tag == "BadDog") 
		{
			Invoke ("ChangeLevel", 0.3f);
		}
	}
	void ChangeLevel()
	{
		SceneManager.LoadScene ("dogDeath");
	}
	void ChangeLevel1()
	{
		SceneManager.LoadScene ("mineDeath");
	}
}
