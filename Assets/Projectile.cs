﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	GameObject prefab;
	GameObject explosion;
	// Use this for initialization
	void Start () {
		prefab = Resources.Load ("SubProjectile") as GameObject;
		explosion = Resources.Load ("Boom") as GameObject;
		StartCoroutine (split ());
	}
	
	// Update is called once per frame
	void Update () {
		//rb.velocity = 1.01f * rb.velocity;

	}
	IEnumerator split(){
		yield return new WaitForSeconds(2.0f);
		//Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
		//position = Camera.main.ScreenToWorldPoint(position);
		GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
		GameObject projectile2 = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
		GameObject kaboom = Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
		Rigidbody p1 = projectile.GetComponent<Rigidbody>();
		p1.velocity = projectile.transform.right*100;
		Rigidbody p2 = projectile2.GetComponent<Rigidbody>();
		p2.velocity = projectile2.transform.right*-100;
	}
	void Awake()
	{
		Destroy(this.gameObject, 2.1f);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Wall") {
			
		} else if (other.gameObject.name == "") {
			
		}
	}
}
