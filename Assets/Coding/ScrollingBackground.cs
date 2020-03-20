using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {
	public float scrollSpeed;
	Vector2 GerakTexture;
	Renderer gambar;

	// Use this for initialization
	void Start () {
		gambar = GetComponent<Renderer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		GerakTexture = new Vector2 (Time.time * scrollSpeed, 0);

		float h = Input.GetAxis ("Horizontal");

		if (h > 0) {
			gambar.sharedMaterial.SetTextureOffset ("_MainTex", GerakTexture);
		}
	}
}
