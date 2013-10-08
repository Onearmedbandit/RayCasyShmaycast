using UnityEngine;
using System.Collections;

public class NPCMove : MonoBehaviour {
	//int randomNumber = random.range(1,10)
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Physics.Raycast(transform.position, transform.forward, 2f)){
			float randomNumber = Random.Range (0f,10f);
			if (randomNumber < 5) {
				transform.Rotate(0f,-90f,0f);
			}
			else {
				transform.Rotate (0f,90f,0f);
			}
		}
		//if (Vector3.Distance(//RayCastHit - Current position) < 5f)
				//random.range(1,10)
			//if(randomNumber < 5)
				//transform.position Vector3.rotation (0f,-90f,0f)
			//else
				//transform.position Vector3.rotation (0f,90f,0f)
	}
	void FixedUpdate(){
		rigidbody.AddForce (transform.forward*10f);
	}
}
