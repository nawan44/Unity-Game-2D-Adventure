using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batas_pemain : MonoBehaviour {
	

	bool IsDead = false;
	Animator anim;
	BoxCollider2D box;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		box = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update (){} 



	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player" ) {
			IsDead = true;
			anim.SetBool("mati", IsDead);
			box.enabled = false;

			Destroy (gameObject, 4f);
		}


	}
}
