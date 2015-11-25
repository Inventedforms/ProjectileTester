using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {

	// Use this for initialization
	GameObject prefab;
	void Start () {
		prefab = Resources.Load ("Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 position = new Vector3(Input.mousePosition.x, 5.0f ,Input.mousePosition.y);
			position = Camera.main.ScreenToWorldPoint(position);
			GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			projectile.transform.LookAt(position);

			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = projectile.transform.forward*50;
			//rb.AddForce(position);
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "") {
		
		} else if (other.gameObject.name == "") {
		
		}
	}
}