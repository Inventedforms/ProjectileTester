using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {
	GameObject boom;
	// Use this for initialization
	void Start () {
		boom = Resources.Load ("Boom") as GameObject;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other){
		GameObject b = Instantiate (boom, transform.position, Quaternion.identity) as GameObject;
		Destroy (this.gameObject);
	
	}
}
