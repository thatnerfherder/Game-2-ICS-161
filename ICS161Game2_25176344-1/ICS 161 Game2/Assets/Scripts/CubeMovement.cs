using UnityEngine;
using System.Collections;


public class CubeMovement : MonoBehaviour {

	public int speed;
	public GameObject Capsule;
	public int bulletSpeed;
	public float numSecondsToFuckingChill;
	bool waitingDone = true;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A) && transform.position.x > -23.5)
			transform.Translate (Vector3.left * speed * Time.deltaTime, Space.World);
		if(Input.GetKey(KeyCode.D) && transform.position.x < 23.5)
			transform.Translate (Vector3.right * speed * Time.deltaTime, Space.World);
		if (Input.GetKeyDown (KeyCode.Space) && waitingDone) {
			GameObject bullet = Instantiate (Capsule, transform.position, transform.rotation) as GameObject;
			bullet.GetComponent<Rigidbody>().velocity = transform.TransformDirection (Vector3.up * bulletSpeed);
			waitingDone = false;
			StartCoroutine (waitASecBruh ());
		}
			
	}

	IEnumerator waitASecBruh(){
		yield return new WaitForSeconds (numSecondsToFuckingChill);
		waitingDone = true;
	}
}
