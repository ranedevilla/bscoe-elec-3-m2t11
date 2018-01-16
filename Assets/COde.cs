using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COde : MonoBehaviour {
	Rigidbody _rb;
	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput ();
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.name == "Cube(5)") {
			col.gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
	}

	public void ProcessInput ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			_rb.AddRelativeForce (Vector3.up*10);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.left);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.right);
		}
	}
}
