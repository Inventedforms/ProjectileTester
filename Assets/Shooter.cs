using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	// Use this for initialization
	GameObject prefab;
	void Start () {
		prefab = Resources.Load ("Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
			position = Camera.main.ScreenToWorldPoint(position);
			GameObject projectile = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			projectile.transform.LookAt(position);
			
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = projectile.transform.forward*100;
			rb.AddForce(projectile.transform.forward*1000);
		}
		if(Input.GetMouseButtonDown(1)){
			Vector3 position = Input.mousePosition;
			position.y = 2.0f;
			position = Camera.main.ScreenToWorldPoint(position);
			GameObject mine = Instantiate (prefab, position, Quaternion.identity) as GameObject;
			//mine.transform.LookAt(position);
		}
	}
	
}