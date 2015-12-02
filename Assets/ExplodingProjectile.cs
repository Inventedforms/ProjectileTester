using UnityEngine;
using System.Collections;

public class ExplodingProjectile : MonoBehaviour {
	GameObject explosion;
	// Use this for initialization
	void Start () {
		explosion = Resources.Load ("Boom") as GameObject;
		StartCoroutine (delay ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator delay(){
		yield return new WaitForSeconds (5.0f);
		explode ();
	}
	void explode(){
		GameObject kaboom = Instantiate (explosion, transform.position, Quaternion.identity) as GameObject;
		Destroy (this.gameObject);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Wall") {
			
		} else if (other.gameObject.name == "") {
			
		}
	}
}
