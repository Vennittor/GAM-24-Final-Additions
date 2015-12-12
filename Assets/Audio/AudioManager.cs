﻿using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour 
{
	public AudioSource sfx;
	public static AudioManager instance = null;
	public GameObject prefab = null;

	private GameObject go = null;

	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	public void PlaySound (AudioClip clip)
	{
		go = Instantiate (prefab);
		sfx = go.GetComponent<AudioSource> ();
		sfx.clip = clip;
		sfx.Play ();

		Destroy (go, clip.length);
	}
}
