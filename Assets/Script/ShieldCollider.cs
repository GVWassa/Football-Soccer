using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollider : MonoBehaviour {

	AudioSource Ball;
	public AudioClip thrown;


	// Use this for initialization
	void Start () {
		Ball = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
	if(other.gameObject.CompareTag("Shield")){
		other.gameObject.SetActive(false);
		}

	if(other.gameObject.CompareTag("Ball")){
			Ball.PlayOneShot(thrown, 9.7f);
		}


	}
}