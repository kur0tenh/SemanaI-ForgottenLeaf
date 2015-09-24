using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public bool Control= false;
	public float rotationVelocity = 5f;
	public GameObject AmmoType;
	public bool rojo;
	// Use this for initialization
	void Start () {
		rojo = true;
		this.GetComponent<SpriteRenderer>().color = Color.cyan;
	}
	
	// Update is called once per frame
	void Update () {

		if (Control) {
			if(Mathf.Sqrt(Mathf.Pow(Input.GetAxis ("RotationX"),2)+Mathf.Pow(Input.GetAxis ("RotationY"),2))>=0.8){
				this.transform.rotation = Quaternion.Euler (0, 0, ((Mathf.Atan2 (Input.GetAxis ("RotationX"), Input.GetAxis ("RotationY"))) * Mathf.Rad2Deg));
			}
			if (Input.GetAxis ("Rojo") > 0) {
				this.GetComponent<SpriteRenderer> ().color = new Color (0,255,0,1);
				rojo = true;
			}
			if (Input.GetAxis ("Azul") > 0) {
				this.GetComponent<SpriteRenderer> ().color = Color.cyan;
				rojo = false;
				
			}
		} else {
			if (Input.GetKey ("left")) {
				transform.Rotate(0, 0,rotationVelocity);
			}
			if (Input.GetKey ("right")) {
				transform.Rotate(0, 0,-rotationVelocity);
			}
			if(Input.GetKeyDown(KeyCode.Z)){
				this.GetComponent<SpriteRenderer>().color = new Color(0,255,0,1);
				rojo=true;
			}
				if(Input.GetKeyDown(KeyCode.X)){
					this.GetComponent<SpriteRenderer>().color = Color.cyan;
				rojo =false;
				}
			}
		}

	}
