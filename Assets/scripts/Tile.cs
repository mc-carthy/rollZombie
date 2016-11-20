﻿using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameManager gameManager;
	public AudioClip hit;
	private AudioSource source;

	private void Start () {
		source = GetComponent<AudioSource> ();
	}

	private void OnTriggerEnter (Collider other) {
		gameManager.AddPoint ();
		source.PlayOneShot (hit);
	}
}
