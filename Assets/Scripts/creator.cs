using UnityEngine;
using System.Collections;

public class creator : MonoBehaviour {
	//float speed = GameObject.Find("maple").GetComponent<Controler2>().maxSpeed;
	private int randy;
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;

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
	
	// Update is called once per frame
	void Update () {
		randy = Random.Range (0, 800);

		if (randy == 1) {
			Instantiate (levels [Random.Range (0, 6)]);
		}
	}
}