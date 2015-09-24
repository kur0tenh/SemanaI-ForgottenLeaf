using UnityEngine;
using System.Collections;

public class Rnave : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.gameObject.transform.Rotate (new Vector3(0,0,5));
	}
}
