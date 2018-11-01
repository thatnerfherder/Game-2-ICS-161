using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
	public Button restart;
	public Button quit;

	// Use this for initialization
	void Start () {
		Button btn = restart.GetComponent<Button> ();
		Button btn2 = quit.GetComponent<Button> ();
		btn.onClick.AddListener (RestartGame);
		btn2.onClick.AddListener (QuitGame);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void RestartGame(){
		SceneManager.LoadScene ("scene1");
	}
	void QuitGame(){
		Application.Quit ();
	}
}
