using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RightCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		GameStatus.increaseLeft();

		if (GameStatus.isFinished ()) {
			SceneManager.LoadScene("Win");
		} else {
			Ball.dead = true;
		}
	}
}
