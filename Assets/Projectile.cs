using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rb.velocity = 1.01f * rb.velocity;
	}
	void Awake()
	{
		Destroy(this.gameObject, 3.0f);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Wall") {
			
		} else if (other.gameObject.name == "") {
			
		}
	}
}
