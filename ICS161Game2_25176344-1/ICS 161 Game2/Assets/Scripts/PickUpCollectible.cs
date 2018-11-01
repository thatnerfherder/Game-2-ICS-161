using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUpCollectible : MonoBehaviour {

	public int score;
	public Text scoretext;

	// Use this for initialization
	void Start () {
		score = 0;
		scoretext.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		if (score == 8)
			SceneManager.LoadScene ("Winner");
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "bomb") {
			SceneManager.LoadScene ("GameOver");
		}
		if (other.tag == "collectible") {
			Destroy (other.gameObject);
			scoretext.text = "Score: " + ++score;
		}	
	}
}