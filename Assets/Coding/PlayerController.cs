using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 5f;
	bool hadapKanan = true;
	Rigidbody2D player;
	public float tinggiLompatan = 5f;
	public LayerMask grupObjek;
	public bool injakTanah = false;
	public float lebarSensor = 0.5f;
	public Transform Sensor;
	Animator playerAnim;
	bool sedangLompat = true;
	public AudioClip SuaraKoin;
	public AudioClip SuaraLompat;

	AudioSource musicPlayer;
	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
		playerAnim = GetComponent<Animator> ();
		musicPlayer = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		GerakPlayer ();
	}

	void GerakPlayer(){
		float ControlButtons = Input.GetAxis ("Horizontal");

		playerAnim.SetFloat ("walking", Mathf.Abs(ControlButtons));
		playerAnim.SetBool ("lompat", sedangLompat);

		transform.position += Vector3.right * ControlButtons * speed * Time.deltaTime;

		if (ControlButtons > 0 && hadapKanan == false) {
			UbahArah ();
		} 
		else if (ControlButtons < 0 && hadapKanan == true) {
			UbahArah ();
		}

		injakTanah = Physics2D.OverlapCircle (Sensor.position, lebarSensor, grupObjek);
		sedangLompat = false;

		if (Input.GetButtonDown ("Jump") && injakTanah == true) {
			player.velocity = new Vector2 (player.velocity.x, tinggiLompatan);
			sedangLompat = true;
			musicPlayer.PlayOneShot (SuaraLompat);
		}
	}

	void UbahArah(){
		hadapKanan = !hadapKanan;
		Vector3 arahHadap = transform.localScale;
		arahHadap.x *= -1;
		transform.localScale = arahHadap;
	}




	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Musuh") {
			Destroy (gameObject);
		}

	
	}
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "koin"){
			musicPlayer.PlayOneShot (SuaraKoin);
		}
	}

	void OnDrawGizmos(){
		Gizmos.DrawSphere (Sensor.position, lebarSensor);
	}

}
