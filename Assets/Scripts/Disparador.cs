using UnityEngine;
using System.Collections;

public class Disparador : MonoBehaviour {
	public GameObject AmmoType;
	private bool control = false;
	//public int ShootingRate=0.1;
	public int n;
	public int limite;


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
		if (control) {
			if ((Input.GetAxis ("Fire1")==1||(Input.GetAxis ("Fire1")==-1))){	
				AmmoType.GetComponent<SpriteRenderer>().color = this.GetComponentInParent<SpriteRenderer>().color;
				AmmoType.GetComponent<Transform> ().position = this.transform.position;
				AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
				Instantiate (AmmoType);
				SoundEffectsHelper1.Instance.makeShootingSound();
				//StartCoroutine(sr (1));
			}
			
		} else {
			if (Input.GetKey ("up") ){
				AmmoType.GetComponent<SpriteRenderer>().color = this.GetComponentInParent<SpriteRenderer>().color;
				AmmoType.GetComponent<Transform> ().position = this.transform.position;
				AmmoType.GetComponent<Disparo> ().Angle = this.transform.rotation;
				Instantiate (AmmoType);
				SoundEffectsHelper1.Instance.makeShootingSound();
				//StartCoroutine(sr (1));
				
			}
		} 
	}


}

