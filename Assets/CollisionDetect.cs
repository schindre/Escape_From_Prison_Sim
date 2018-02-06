using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {


		AudioSource audioSource;
	    public GameObject Mine;
	public GameObject InnerMineArea;
	public GameObject OuterMineArea;
	bool a;
	bool b;


		void Start()
		{
			audioSource = GetComponent<AudioSource>();
		}
		
	void OnTriggerStay(Collider collider)
	{
		if (collider.tag == "mine") {
			Debug.Log ("mine");
			Pitcher.PlaySound ("Explosion");
			b = false;
		} else {
			b = true;
		}
		if (collider.tag == "InnerMineArea" && b) {
			Debug.Log ("InnerMineArea");
			Pitcher.PlaySound ("Inner");
			a = false;
		} else {
			a = true;
		}
		if (collider.tag == "OuterMineArea" && a) {
			Debug.Log ("OuterMineArea");
			Pitcher.PlaySound ("Outer");
		}
		if (collider.tag == "Normalize" && a) {
			Debug.Log ("Normalize");
			Pitcher.PlaySound ("Normalize");
			/*
			foreach ()
			{
				Debug.DrawRay(contact.point, contact.normal, Color.white);
			}
			if ()
				audioSource.Play();*/
		}
	}
	}