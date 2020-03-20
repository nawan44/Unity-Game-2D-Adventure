using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {
	public string namaScene;
	public static bool  Enter_Finish = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)){
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			if (Enter_Finish == true) {
				SceneManager.LoadScene (namaScene);
			}
		}
	}
}
