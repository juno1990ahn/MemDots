using UnityEngine;
using System.Collections;

public class Dot : MonoBehaviour {
	public int index;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		Debug.Log ("Mouse Click on index : " + index);
	}

	public void Initiate(int index) {
		this.index = index;
	}
}
