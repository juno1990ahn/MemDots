using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public int level = 1;
	private LevelManager levelManager;
	
	void Awake () {
		Debug.Log ("AWAKE");
		if (instance == null) 
			instance = this;
		else if (instance != this) 
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		levelManager = GetComponent<LevelManager> ();
		Debug.Log ("GM awake");
		Init ();
	}

	void Init() {
		Debug.Log ("GM init");
		levelManager.SetupLevel (level);
	}

	void Update () {

	}
}