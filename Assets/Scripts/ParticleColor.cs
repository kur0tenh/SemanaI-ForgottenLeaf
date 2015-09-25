using UnityEngine;
using System.Collections;

public class ParticleColor : MonoBehaviour {
	public GameObject colori;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			this.GetComponent<ParticleSystem> ().startColor = Rotation.elColor;
	}}
