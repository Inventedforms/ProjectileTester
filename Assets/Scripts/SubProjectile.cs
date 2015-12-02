using UnityEngine;
using System.Collections;

public class SubProjectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake(){
		Destroy (this.gameObject, 2.0f);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Wall") {
			
		} else if (other.gameObject.name == "") {
			
		}
	}
}
