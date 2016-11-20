using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameManager : MonoBehaviour {

	private int selectedZombiePosition = 0;
	public GameObject selectedZombie;
	public List<GameObject> zombies;
	public Vector3 selectedSize;
	public Vector3 defaultSize;

	private void Start () {
		SelectZombie (selectedZombie);
	}

	private void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GetZombieLeft ();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GetZombieRight ();
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			PushUp ();
		}
	}

	private void SelectZombie (GameObject newZombie) {
		selectedZombie.transform.localScale = defaultSize;
		selectedZombie = newZombie;
		newZombie.transform.localScale = selectedSize;
	}

	private void GetZombieLeft () {
		if (selectedZombiePosition == 0) {
			selectedZombiePosition = 3;
		} else {
			selectedZombiePosition--;
		}
		SelectZombie (zombies [selectedZombiePosition]);
	}

	private void GetZombieRight () {
		if (selectedZombiePosition == 3) {
			selectedZombiePosition = 0;
		} else {
			selectedZombiePosition++;
		}
		SelectZombie (zombies [selectedZombiePosition]);
	}

	private void PushUp () {
		Rigidbody rb = selectedZombie.GetComponent<Rigidbody> ();
		rb.AddForce (0, 0, 10, ForceMode.Impulse);
	}
}
