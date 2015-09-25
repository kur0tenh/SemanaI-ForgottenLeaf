using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
	public bool Control= false;
	public float rotationVelocity = 5f;
	public GameObject AmmoType;
	public GameObject Ammotype2;
	public GameObject Ammotype3;
	public static Color elColor;
	public bool rojo;
	public bool lados = false;
	public bool atras = false;
	// Use this for initialization
	void Start () {
		rojo = true;
		this.GetComponent<SpriteRenderer>().color = Color.cyan;
	}
	
	// Update is called once per frame
	void Update () {
		elColor = this.GetComponent<SpriteRenderer>().color;
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
			if(Input.GetKeyDown(KeyCode.Q)){
				this.GetComponent<SpriteRenderer>().color = new Color(0,255,0,1);
				rojo=true;
			}
				if(Input.GetKeyDown(KeyCode.E)){
					this.GetComponent<SpriteRenderer>().color = Color.cyan;
				rojo =false;
				}
			}
		}
	void OnCollisionEnter2D(Collision2D other){
	if (other.gameObject.tag == "fireRate") {
			this.GetComponentInChildren<Disparador> ().limite = this.GetComponentInChildren<Disparador> ().limite - 5;
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "doble" && AmmoType != Ammotype2) {
			foreach(Disparador sr in GetComponentsInChildren<Disparador>()) {
				sr.AmmoType =Ammotype2;
			}
			Destroy (other.gameObject);
			AmmoType = Ammotype2;
		} else if (other.gameObject.tag == "doble" && AmmoType == Ammotype2 ) {
			foreach(Disparador sr in GetComponentsInChildren<Disparador>()) {
				sr.AmmoType =Ammotype3;
			}
			Destroy (other.gameObject);
		}
		else if (other.gameObject.tag == "lados") {
			lados = true;
			Destroy (other.gameObject);
		}
		else if (other.gameObject.tag == "atras") {
			atras = true;
			Destroy (other.gameObject);
		}
	}

	}
