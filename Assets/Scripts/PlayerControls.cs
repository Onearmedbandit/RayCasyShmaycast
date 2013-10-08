using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.AddForce(Vector3.left);
			}
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody.AddForce(Vector3.right);
			}
		if (Input.GetKey(KeyCode.Space)){
			
			//if(Create RayCast(From Center of PLayer, Vector3.down, 3f)){
		rigidbody.AddForce(Vector3.up);
			}
}
}
