using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	
	// Use this for initialization
	GameObject standard;
	GameObject highvelocity;
	GameObject explosive;
	GameObject pellet;
	GameObject beacon;
	int key;
	bool fired;
	void Start () {
		standard = Resources.Load ("Projectile") as GameObject;
		highvelocity = Resources.Load ("RomanCandle") as GameObject;
		explosive = Resources.Load ("ExplodingProjectile") as GameObject;
		pellet = Resources.Load ("SubProjectile") as GameObject;
		beacon = Resources.Load ("Beacon") as GameObject;
		key = 1;
		fired = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){key = 1;}
		else if(Input.GetKeyDown (KeyCode.Alpha2)){key = 2;}
		else if(Input.GetKeyDown (KeyCode.Alpha3)){key = 3;}
		else if(Input.GetKeyDown (KeyCode.Alpha4)){key = 4;}
		else if(Input.GetKeyDown (KeyCode.Alpha5)){key = 5;}
		if(Input.GetMouseButtonDown(0)){
			if(!fired){
				switch(key){
				case 1:
					fired = true;
					StartCoroutine(BasicShot());
					break;
				case 2:
					fired = true;
					StartCoroutine(FastShot());
					break;
				case 3:
					fired = true;
					StartCoroutine (ExplosiveShot());
					break;
				case 4:
					fired = true;
					StartCoroutine(SplitShot());
					break;
				case 5:
					fired = true;
					StartCoroutine (Pentagram());
					break;
				}
			}
		}
	}
	IEnumerator BasicShot(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit h;
		if (Physics.Raycast (ray, out h)) {
			GameObject projectile = Instantiate(standard, transform.position, Quaternion.identity) as GameObject;
			Vector3 bulletVel = (h.point - this.transform.position).normalized * 50.0f;
			projectile.transform.GetComponent<Rigidbody>().velocity = (bulletVel + new Vector3((Random.value-0.5f)*20.0f,
			                                                                                (Random.value-0.5f)*20.0f,0.0f));
			yield return new WaitForSeconds(1.0f);
			fired = false;
		}
	}
	IEnumerator FastShot(){
		//Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
		//position = Camera.main.ScreenToWorldPoint(position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit h;
		if (Physics.Raycast (ray, out h)) {
			GameObject projectile = Instantiate(highvelocity, transform.position, Quaternion.identity) as GameObject;
			Vector3 bulletVel = (h.point - this.transform.position).normalized * 200.0f;
			projectile.transform.GetComponent<Rigidbody>().velocity = (bulletVel + new Vector3((Random.value-0.5f)*20.0f,
			                                                                         (Random.value-0.5f)*20.0f,0.0f));
			yield return new WaitForSeconds(1.0f);
			fired = false;
		}
	}
	IEnumerator ExplosiveShot(){
		//Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
		//position = Camera.main.ScreenToWorldPoint(position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit h;
		if (Physics.Raycast (ray, out h)) {
			GameObject projectile = Instantiate(explosive, transform.position, Quaternion.identity) as GameObject;
			Vector3 bulletVel = (h.point - this.transform.position).normalized * 10.0f;
			projectile.transform.GetComponent<Rigidbody>().velocity = (bulletVel + new Vector3((Random.value-0.5f)*20.0f,
			                                                                                   (Random.value-0.5f)*20.0f,0.0f));
			yield return new WaitForSeconds(1.0f);
			fired = false;
		}
	}
	IEnumerator SplitShot(){
		Vector3 position = new Vector3(Input.mousePosition.x, 10.0f ,Input.mousePosition.y);
		position = Camera.main.ScreenToWorldPoint(position);
		GameObject projectile = Instantiate(pellet, transform.position, Quaternion.identity) as GameObject;
		GameObject projectile2 = Instantiate(pellet, transform.position, Quaternion.identity) as GameObject;
		GameObject projectile3 = Instantiate(pellet, transform.position, Quaternion.identity) as GameObject;
		projectile2.transform.position = new Vector3 (projectile.transform.position.x+ 0.5f, projectile.transform.position.y, projectile.transform.position.z);
		projectile3.transform.position = new Vector3 (projectile.transform.position.x, projectile.transform.position.y, projectile.transform.position.z-1.0f);
		projectile.transform.LookAt (position);
		projectile2.transform.LookAt (position);
		projectile3.transform.LookAt (position);
		projectile.GetComponent<Rigidbody> ().velocity = projectile.transform.forward * 50;
		projectile2.GetComponent<Rigidbody> ().velocity = projectile2.transform.forward * 50;
		projectile3.GetComponent<Rigidbody> ().velocity = projectile3.transform.forward * 50;
		yield return new WaitForSeconds (1.5f);
		fired = false;
	}
	IEnumerator Pentagram(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit h;
		if(Physics.Raycast(ray, out h)){
			GameObject p =	Instantiate (beacon, h.point, Quaternion.identity) as GameObject;}
		yield return new WaitForSeconds(2.0f);
		fired = false;
	}
}