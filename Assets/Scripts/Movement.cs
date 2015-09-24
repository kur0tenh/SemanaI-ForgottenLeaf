using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float MovementSensitivity = 2;
	Vector2 Move = new Vector2 (0,0);
	// Use this for initialization
	void Start () {
		MovementSensitivity *= 0.1f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
		this.transform.Translate(Move*MovementSensitivity);

	}
}
