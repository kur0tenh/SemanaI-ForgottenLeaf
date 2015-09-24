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

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (LifeSettings.lifes > 0) {
			if (LifeSettings.health <= 0) {
				LifeSettings.lifes--;
			}
			
		} else {
			Destroy(this.gameObject);

		}
	}	
	void OnCollisionEnter2D(Collision2D HarmfullObject){
		if (HarmfullObject.gameObject.GetComponent<LifeBasics> ()!=null) {
			if(isEnemy && this.isPlayer){
				this.LifeSettings.health--;
			}
		} 
	}
}
