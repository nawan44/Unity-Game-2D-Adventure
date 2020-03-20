using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameUIManager : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BukaGame(){
		Application.LoadLevel (0);
	}
	public void TentangGame(){
		Application.LoadLevel (1);
	}
	public void MulaiGame(){
		Application.LoadLevel (2);
	}

	public void KeluarGame(){
		Application.Quit();
	}
}
