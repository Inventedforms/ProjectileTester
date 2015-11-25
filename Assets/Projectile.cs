using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = rb.velocity*1.01f;
	}
	void Awake()
	{
		Destroy(this.gameObject, 5.0f);
	}
}
