using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Orange : MonoBehaviour {
	public LevelLoader levelLoader;

	void Start()
	{
		levelLoader = GameObject.Find ("GameManager").GetComponent<LevelLoader>();
	}

	void OnTriggerEnter(Collider player){
		if (player.gameObject.tag == "Player") {
			GetComponent<BoxCollider> ().enabled = false;
			GetComponent<SpriteRenderer> ().enabled = false;

			levelLoader.OrangeCount--;
			Debug.Log ("TRIGGER ENTER");
		}
	}

}
