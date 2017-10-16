using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {

	public GameObject prefab;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		prefab = Resources.Load("Ball") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
		GameObject Ball = Instantiate(prefab) as GameObject;
		Ball.transform.position = transform.position + Camera.main.transform.forward * 2;
		Rigidbody rb = Ball.GetComponent<Rigidbody>();
		rb.velocity = Camera.main.transform.forward * 40;
		}
	}
}

//Sources: https://www.youtube.com/watch?v=DEtZUeVY9qk
