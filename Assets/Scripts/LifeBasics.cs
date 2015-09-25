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
		if (LifeSettings.lifes > 0) {
			if (LifeSettings.health <= 0) {
				LifeSettings.lifes--;
				
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
