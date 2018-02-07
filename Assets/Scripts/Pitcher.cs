using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{

	public static AudioClip Outer, Inner, Explosion, Normalize;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start()
	{
		Outer = Resources.Load<AudioClip>("Outer");
		Inner = Resources.Load<AudioClip>("Inner");
		Explosion = Resources.Load<AudioClip>("Explosion");
		Normalize = Resources.Load<AudioClip>("Normalize");

		audioSrc = GetComponent<AudioSource>();

		//PlaySound("Backgroundmusic");
	}

	public static void PlaySound(string clip)
	{
		switch (clip)
		{
		case "Outer":
			audioSrc.pitch = (1.5f);
			break;
		
		case "Inner":
			audioSrc.pitch = (2f);
			break;

		case "":
			audioSrc.PlayOneShot(Explosion);
			audioSrc.pitch = (1f);
			break;
		
		case "Normalize":
			audioSrc.pitch = (1f);
			break;
		
		}
	}
}
