using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanarInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		transform.position += new Vector3(x, 0, z);

		float zoom = Input.GetAxis("Zoom");
		transform.Translate(0, 0, zoom);
	}
}
