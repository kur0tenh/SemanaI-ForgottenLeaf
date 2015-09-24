using UnityEngine;
using System.Collections;

public class creatEnemy : MonoBehaviour {
	private int randy;
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;
	public ArrayList alist;
	GameObject[] levels = new GameObject[7]; 
	// Use this for initialization
	void Start () {
		
		levels[0] = enemy;
		levels[1] = enemy1;
		levels[2] = enemy2;
		levels[3] = enemy3;
		levels[4] = enemy4;
		levels[5] = enemy5;
		levels[6] = enemy6;
	}
	float height = this.GetComponentInParent<Camera>().orthographicSize*2f;
	float width = this.GetComponentInParent<Camera>().aspect*height;
	// Update is called once per frame
	void FixedUpdate () {

		randy = Random.Range (0, 400);
		
		if (randy == 1) {
			GameObject Spawn = (GameObject)Instantiate (levels [Random.Range (0, 6)], transform.position, transform.rotation);
		}
	}
}
