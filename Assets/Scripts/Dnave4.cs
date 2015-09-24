using UnityEngine;
using System.Collections;

public class Dnave4 : MonoBehaviour {
	public GameObject AmmoType;
	private int n;
	public int limite;
	public float angulo;

	void Start () {
		n = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (n == 0) {
			Shoot ();
			n++;
		} else if(n < limite)
			n++;
		else if (n >= limite)
			n = 0;
	}
	void Shoot(){
				AmmoType.GetComponent<SpriteRenderer>().color = this.GetComponentInParent<SpriteRenderer>().color;
				AmmoType.GetComponent<Transform> ().position = this.transform.position;
		if (AmmoType.GetComponent<ProyectilNave>() != null)
		        AmmoType.GetComponent<ProyectilNave> ().Angle = Quaternion.Euler (0, 0, angulo);
		if (AmmoType.GetComponent<BulletVerde>() != null)
			AmmoType.GetComponent<BulletVerde> ().Angle = Quaternion.Euler (0, 0, angulo);
				Instantiate (AmmoType);
				SoundEffectsHelper1.Instance.makeShootingSound();
				//StartCoroutine(sr (1));
			}
}
