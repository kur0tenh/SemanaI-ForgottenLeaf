using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public bool Control= false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Control) {
			this.transform.rotation = Quaternion.Euler (0, 0, ((Mathf.Atan2 (Input.GetAxis ("RotationX"), Input.GetAxis ("RotationY"))) * Mathf.Rad2Deg));
		} else {
			if (Input.GetKey ("left")) {
				transform.Rotate(0, 0,2);
			}
			if (Input.GetKey ("right")) {
				transform.Rotate(0, 0, -2);
			}
		}
	}
}
