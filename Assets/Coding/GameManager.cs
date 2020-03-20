using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager gm;

	public int score;
	public Text displayScore;


	void Awake(){
		gm = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		displayScore.text = "nilai skor = " + score;	
	}
}
