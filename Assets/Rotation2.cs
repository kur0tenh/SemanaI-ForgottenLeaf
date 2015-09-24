using UnityEngine;
using System.Collections;

public class Rotation2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left")) {
			transform.Rotate(0, .5f, 0);
		}
		if (Input.GetKey ("right")) {
			transform.Rotate(0, -.5f, 0);
		}
		//this.transform.rotation = Quaternion.Euler(0, 0, ((Mathf.Atan2(Input.GetAxis("RotationX"),Input.GetAxis("RotationY")))* Mathf.Rad2Deg));
	}
}
