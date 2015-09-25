using UnityEngine;
using System.Collections;

public class Disparador : MonoBehaviour {
	public GameObject AmmoType;
	private bool control = false;
	//public int ShootingRate=0.1;
	public int n;
	public int limite;
	public float yolo= 0;
	public bool arriba = false;
	public bool atras = false;
	public bool abajo = false;


	// Use this for initialization
	void Start () {
		control = this.GetComponentInParent<Rotation> ().Control;
		n = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (n == 0) {
			Shoot ();
			n++;
		} else if(n < limite)
			n++;
		else if (n >= limite)
			n = 0;

	}/*
	IEnumerator sr(float time){
		yield return new WaitForSeconds (time);
	}
	*/

	void Shoot(){
		if (!atras && !arriba && !abajo) {
			if (control) {
				if ((Input.GetAxis ("Fire1") == 1 || (Input.GetAxis ("Fire1") == -1))) {	
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =  new Vector3(0,0,0);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
				}
			
			} else {
				if (Input.GetKey ("up")) {
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =  new Vector3(0,0,0);
					Instantiate (AmmoType);
					//SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
				
				}
			} 
		} else if (arriba && GetComponentInParent<Rotation>().lados) {
			if (control) {
				if ((Input.GetAxis ("Fire1") == 1 || (Input.GetAxis ("Fire1") == -1))) {	
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle =  this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =  new Vector3(0,0,90);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
				}
				
			} else {
				if (Input.GetKey ("up")) {
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =   new Vector3(0,0,90);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
					
				}
			} 
		}
		else if (abajo&& GetComponentInParent<Rotation>().lados) {
			if (control) {
				if ((Input.GetAxis ("Fire1") == 1 || (Input.GetAxis ("Fire1") == -1))) {	
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle =  this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =   new Vector3(0,0,270);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
				}
				
			} else {
				if (Input.GetKey ("up")) {
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle = Quaternion.Euler(0,0,this.transform.parent.rotation.z+270);
					AmmoType.GetComponent<Disparo> ().Angle2 =   new Vector3(0,0,270);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
					
				}
			} 
		}
		else if (atras&& GetComponentInParent<Rotation>().atras) {
			if (control) {
				if ((Input.GetAxis ("Fire1") == 1 || (Input.GetAxis ("Fire1") == -1))) {	
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle =  this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =   new Vector3(0,0,180);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
				}
				
			} else {
				if (Input.GetKey ("up")) {
					AmmoType.GetComponent<SpriteRenderer> ().color = this.GetComponentInParent<SpriteRenderer> ().color;
					AmmoType.GetComponent<Transform> ().position = this.transform.position;
					AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
					AmmoType.GetComponent<Disparo> ().Angle2 =   new Vector3(0,0,180);
					Instantiate (AmmoType);
					SoundEffectsHelper1.Instance.makeShootingSound ();
					//StartCoroutine(sr (1));
					
				}
			} 
		}
	}


}

