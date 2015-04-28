using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{ 
			GetComponent<Rigidbody> ().velocity = Vector3.zero; 
			GetComponent<Rigidbody> ().AddForce (Vector3.up*200); 
		} 
		if (Input.GetKeyDown (KeyCode.D)) 
		{ 
			GetComponent<Rigidbody> ().velocity = Vector3.zero; 
			GetComponent<Rigidbody> ().AddForce (Vector3.right*100); 
		}
		if (Input.GetKeyDown (KeyCode.F)) 
		{ 
			GetComponent<Rigidbody> ().velocity = Vector3.zero; 
			GetComponent<Rigidbody> ().AddForce (Vector3.right*400); 
		}
		if (Input.GetKeyDown (KeyCode.A)) 
		{ 
			GetComponent<Rigidbody> ().velocity = Vector3.zero; 
			GetComponent<Rigidbody> ().AddForce (Vector3.left*100); 
		}
	}
}
