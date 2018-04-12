using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("LoadScene", 1f);
	}
	
	// Update is called once per frame
	void LoadScene() {
		Scoreboard.runningScore += 10;
		SceneManager.LoadScene(1);
	}
}
