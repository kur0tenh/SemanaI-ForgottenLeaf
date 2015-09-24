using UnityEngine;
using System.Collections;

public class Pnave : MonoBehaviour {
	private int n2;
	public int limiteMovimiento;
	public float speed = .2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		n2++;
		if (n2 < limiteMovimiento / 2)
			this.transform.Translate (new Vector3 (0, -speed, 0));
		if (n2 > limiteMovimiento / 2)
			this.transform.Translate (new Vector3 (0, speed, 0));
		 if (n2 >= limiteMovimiento)
			n2 = 0;
	}
}
