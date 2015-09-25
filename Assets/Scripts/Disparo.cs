using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {

	public Quaternion Angle = Quaternion.Euler(0,0,0);
	public Quaternion Angle2 = Quaternion.Euler(0,0,0);

	public float Magnitude = 1;
	public float tiempoMuerte;
	public GameObject roti;
	public Rotation roto;
	Vector2 Fwrd = new Vector2(0,1);
	// Use this for initialization
	
	void Start () {
		foreach(SpriteRenderer sr in GetComponentsInChildren<SpriteRenderer>()) {
			sr.material.color = this.GetComponent<SpriteRenderer>().color;;
		}
		this.transform.rotation = Angle;
		this.transform.Rotate(new Vector3(Angle2.x,Angle2.y,Angle2.z));
		Destroy (gameObject, tiempoMuerte);
	}

	// Update is called once per frame
	void FixedUpdate () {
		//this.GetComponentsInChildren<SpriteRenderer>().  = this.GetComponent<SpriteRenderer> ;
		this.transform.Translate(Fwrd * Magnitude);
		//this.GetComponent<Rigidbody2D> ().velocity = Fwrd * Magnitude;
		//this.GetComponent<Rigidbody2D>().AddForce(Fwrd*Magnitude);
		
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "MainCamera") {
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.GetComponent<LifeBasics>()==null) {
			Destroy(this.gameObject);
		}
		if (other.gameObject.GetComponent<LifeBasics> () != null) {
			if (!other.gameObject.GetComponent<LifeBasics> ().isPlayer && (other.gameObject.GetComponent<SpriteRenderer>().color.Equals(this.gameObject.GetComponent<SpriteRenderer>().color)||other.gameObject.GetComponent<SpriteRenderer>().color.Equals(Color.white))) {
				other.gameObject.GetComponent<LifeBasics>().LifeSettings.lifes--;
				Destroy(this.gameObject);
			}
		}
	}
}
