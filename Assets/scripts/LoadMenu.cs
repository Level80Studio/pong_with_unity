using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("loadMenu", 3);
	}
	
	public void loadMenu () {
		SceneManager.LoadScene("Menu");
	}

}
