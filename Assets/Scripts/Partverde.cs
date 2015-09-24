using UnityEngine;
using System.Collections;

public class Partverde : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<ParticleSystem>().startColor =  new Color(0,255,0,74);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
