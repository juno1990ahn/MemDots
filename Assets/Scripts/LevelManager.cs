using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

	private List<GameObject> dots;
	private int defaultDotCount = 5;
	public GameObject dotObject;
	public float radius;

	public void SetupLevel(int level) {
		dots = new List<GameObject> ();
		int dotCount = level + defaultDotCount;
		for (int i = 0; i < level + dotCount; i++) {
			float angle = i * Mathf.PI * 2 / dotCount;
			Vector3 pos = new Vector3 (Mathf.Cos (angle), Mathf.Sin (angle), 0) * radius;
			GameObject dot = Instantiate (dotObject, pos, Quaternion.identity) as GameObject;
			dot.GetComponent<Dot>().Initiate(i);
			dots.Add(dot);
		}
	}
}
