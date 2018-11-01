using UnityEngine;
using System.Collections;

public class DestroyBomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= .15)
			Destroy (this.gameObject);
	
	}
}
