using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudio : MonoBehaviour {

	AudioSource myAudio;
	public float delay=2f;

	// Use this for initialization
	void Start () 
	{
		myAudio = GetComponent<AudioSource> ();
		myAudio.PlayDelayed (delay);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
