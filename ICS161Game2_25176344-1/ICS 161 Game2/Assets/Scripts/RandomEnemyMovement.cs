using UnityEngine;
using System.Collections;

public class RandomEnemyMovement : MonoBehaviour {

	public GameObject toFollow;
	public float offset;
	public float speed;
	public GameObject collectible;
	public int numFramesTilSwitch;
	Vector3 goTo;
	int counter = 0;

	// Use this for initialization
	void Start () {
		transform.position = toFollow.transform.position + Vector3.up * offset + Vector3.right * Random.Range(-23, 23) + Vector3.left * Random.Range(-23, 23);
		goTo = toFollow.transform.position + Vector3.up * offset + Vector3.right * Random.Range (-23, 23) + Vector3.left * Random.Range (-23, 23);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, goTo, speed);
		counter++;
		if (counter >= numFramesTilSwitch) {
			goTo = toFollow.transform.position + Vector3.up * offset + Vector3.right * Random.Range (-23, 23) + Vector3.left * Random.Range (-23, 23);
			counter = 0;
		}

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "bullet") {
			Destroy (this.gameObject);
			GameObject pickUp = Instantiate (collectible, transform.position, transform.rotation) as GameObject;
		}
	}
		
}
