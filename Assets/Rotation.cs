using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Euler(0, 0, ((Mathf.Atan2(Input.GetAxis("RotationX"),Input.GetAxis("RotationY")))* Mathf.Rad2Deg));
	}
}
