using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public GameManager gameManager;

	private void OnTriggerEnter (Collider other) {
		gameManager.AddPoint ();
	}
}
