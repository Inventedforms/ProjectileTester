using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	// Use this for initialization
	GameObject prefab;
	GameObject marker;
	void Start () {
		prefab = Resources.Load ("Projectile") as GameObject;
		marker = Resources.Load ("Pentacle") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
			position = Camera.main.ScreenToWorldPoint(position);
			GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			projectile.transform.LookAt(position);
			
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = projectile.transform.forward*10;
			rb.AddForce(projectile.transform.forward*1000);
		}
		if(Input.GetMouseButtonDown(1)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit h;
			if(Physics.Raycast(ray, out h, 1000)){
			GameObject p =	Instantiate (marker, h.point, Quaternion.identity) as GameObject;
			} 
		}
	}
	
}