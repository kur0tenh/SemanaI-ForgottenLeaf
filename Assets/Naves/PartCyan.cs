using UnityEngine;
using System.Collections;

public class PartCyan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<ParticleSystem> ().startColor = Color.cyan;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
