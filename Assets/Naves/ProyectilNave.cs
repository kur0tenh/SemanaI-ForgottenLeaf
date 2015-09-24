using UnityEngine;
using System.Collections;

public class ProyectilNave : MonoBehaviour {
	public Quaternion Angle = Quaternion.Euler(0,0,0);
	Vector2 Fwrd = new Vector2(0,1);
	public float Magnitude = 1;
	public float tiempoMuerte;


	// Use this for initialization
	void Start () {
		this.transform.rotation = Angle;
		this.GetComponent<SpriteRenderer> ().color = Color.cyan;
		Destroy (gameObject, tiempoMuerte);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Fwrd * Magnitude);
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "MainCamera") {
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.GetComponent<LifeBasics>()==null) {
			Destroy(this.gameObject);
		}
		if (other.gameObject.GetComponent<LifeBasics> () != null) {
			if (other.gameObject.GetComponent<LifeBasics> ().isPlayer) {
				other.gameObject.GetComponent<LifeBasics> ().LifeSettings.lifes--;
				Destroy (this.gameObject);
			}
		}
	}
}
