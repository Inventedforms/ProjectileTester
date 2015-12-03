using UnityEngine;
using System.Collections;

public class ExplodingProjectile : MonoBehaviour {
	GameObject explosion;
	GameObject p;
	// Use this for initialization
	void Start () {
		explosion = Resources.Load ("Elecball") as GameObject;
		p = Resources.Load ("Explosion") as GameObject;
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
		GameObject k = Instantiate (p, transform.position, Quaternion.identity) as GameObject;
		Collider[] targets = Physics.OverlapSphere (transform.position, 10.0f);
		for(int i = 0; i < targets.Length; i++){
		//Now do something to the targets
		}
		Destroy (this.gameObject);
	}
	void OnTriggerEnter(Collider other){
		explode ();

	}
}
