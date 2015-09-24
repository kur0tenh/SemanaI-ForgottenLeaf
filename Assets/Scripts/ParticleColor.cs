using UnityEngine;
using System.Collections;

public class ParticleColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<ParticleSystem>().startColor = this.GetComponentInParent<SpriteRenderer>().color;
	}
}
