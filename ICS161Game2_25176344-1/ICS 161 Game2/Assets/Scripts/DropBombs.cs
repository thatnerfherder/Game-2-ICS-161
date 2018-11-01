using UnityEngine;
using System.Collections;

public class DropBombs : MonoBehaviour {

	public GameObject Capsule;
	public float percentage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Random.value < percentage) {
			GameObject bomb = Instantiate (Capsule, transform.position, transform.rotation) as GameObject;
		}
	}
}
