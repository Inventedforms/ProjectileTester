using UnityEngine;
using System.Collections;

public class Beacon : MonoBehaviour {
	GameObject pentagram;
	GameObject meteor;
	// Use this for initialization
	void Start () {
		pentagram = Resources.Load ("Pentacle") as GameObject;
		meteor = Resources.Load ("Meteor") as GameObject;
		GameObject p = Instantiate (pentagram, transform.position, Quaternion.identity) as GameObject;
		StartCoroutine (meteorstrike ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator meteorstrike(){
		yield return new WaitForSeconds(3.3f);
		Vector3 pos = new Vector3 (transform.position.x, transform.position.y + 100, transform.position.z);
		GameObject m = Instantiate (meteor, pos, Quaternion.identity) as GameObject;
		//m.GetComponent<Rigidbody> ().AddForce (new Vector3(0, -1000, 0));
		m.GetComponent<Rigidbody> ().velocity = new Vector3 (0, -60, 0);
		Destroy (this.gameObject);
	}
	void OnTriggerEnter(Collider other){
	}
}
