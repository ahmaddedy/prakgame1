using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public AudioClip jump;
	public AudioClip leftright;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{ 
			audio.clip=jump;
			audio.Play();
			GetComponent<Rigidbody> ().velocity = Vector3.zero; 
			GetComponent<Rigidbody> ().AddForce (Vector3.up*200); 
		} 
		if (Input.GetKeyDown (KeyCode.D)) 
		{ 
			audio.clip=leftright;
			audio.Play();
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

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "point")
			other.gameObject.audio.Play ();
	}
	void OnCollisionExit(Collision other) {
		if (other.gameObject.tag == "point")
			other.gameObject.audio.Stop();
	}
}
