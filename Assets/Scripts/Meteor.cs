using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {
	GameObject boom;
	// Use this for initialization
	void Start () {
		boom = Resources.Load ("Explosion") as GameObject;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other){
		GameObject b = Instantiate (boom, transform.position, Quaternion.identity) as GameObject;
		Collider[] targets = Physics.OverlapSphere (transform.position, 20.0f);
		for(int i = 0; i < targets.Length; i++){
			//Now do something to the targets
		}
		Destroy (this.gameObject);
	
	}
}
