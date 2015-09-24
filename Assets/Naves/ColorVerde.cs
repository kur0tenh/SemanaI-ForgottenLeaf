using UnityEngine;
using System.Collections;

public class ColorVerde : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<SpriteRenderer> ().color = new Color (0, 255, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
