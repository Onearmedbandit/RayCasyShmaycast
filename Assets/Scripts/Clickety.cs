using UnityEngine;
using System.Collections;

public class Clickety : MonoBehaviour {

	Vector3 newDestination;

	// Use this for initialization
	void Start () {
		newDestination = transform.position;
	}

	// Update is called once per frame
	void Update () {
	   
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
		RaycastHit rayHit = new RaycastHit();
		
		if (Physics.Raycast( ray, out rayHit, 10000f))
		{
			Vector3 newDestination = rayHit.point;
			
		}
		
		
	

	}

void FixedUpdate () {
		if (Vector3.Distance(newDestination, transform.position) > 50)
		{
			Vector3 direction = Vector3.Normalize( newDestination - transform.position );
        	rigidbody.AddForce( direction * 200);
	
		}
}
}