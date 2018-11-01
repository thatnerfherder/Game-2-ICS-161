using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= .15 || transform.position.y > 10)
			Destroy (this.gameObject);
	
	}

	//void OnTriggerEnter(Collider collider){
	//	if (collider.tag == "ground")
	//		Destroy (this.gameObject);
	//}
}
