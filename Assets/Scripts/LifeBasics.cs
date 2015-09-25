using UnityEngine;
using System.Collections;
[System.Serializable]
public class LifeAttributes{
	public int lifes = 1;
	public int health = 1;
	public bool Cyan = false;
	public bool LightGreen = false;
}

public class LifeBasics : MonoBehaviour {
	public LifeAttributes LifeSettings;
	public bool isEnemy = false;
	public bool isPlayer = false;
	public bool isBoss = false;
	public static int cont;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (score.puntaje);
		if (LifeSettings.lifes > 0) {
			if (LifeSettings.health <= 0) {
				LifeSettings.lifes--;
				if(isPlayer && score.puntaje> PlayerPrefs.GetInt("puntaje1"))
					PlayerPrefs.SetInt("puntaje1",score.puntaje);
				else if(isPlayer && score.puntaje> PlayerPrefs.GetInt("puntaje2"))
					PlayerPrefs.SetInt("puntaje2",score.puntaje);
				else if(isPlayer && score.puntaje> PlayerPrefs.GetInt("puntaje3"))
					PlayerPrefs.SetInt("puntaje3",score.puntaje);
				else if(isPlayer && score.puntaje> PlayerPrefs.GetInt("puntaje4"))
					PlayerPrefs.SetInt("puntaje4",score.puntaje);
				else if(isPlayer && score.puntaje> PlayerPrefs.GetInt("puntaje5"))
					PlayerPrefs.SetInt("puntaje5",score.puntaje);
				SpecialEffectsHelper.Instance.Explosion(transform.position);
			}
			
		} else {
			cont--;
			//Destroy(this.gameObject);
			this.gameObject.SetActive(false); 
			SpecialEffectsHelper.Instance.Explosion(transform.position);
		}
	}	
	void OnCollisionEnter2D(Collision2D HarmfullObject){
		if (HarmfullObject.gameObject.GetComponent<LifeBasics> ()!=null) {
			if(HarmfullObject.gameObject.GetComponent<LifeBasics>().isEnemy && this.isPlayer){
				this.LifeSettings.lifes--;

			}
		} 
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "MainCamera"&&this.isEnemy) {
			//this.gameObject.SetActive(false);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "MainCamera"&&this.isEnemy) {
			//this.gameObject.SetActive(true);

		}
	}
}
