using UnityEngine;
using System.Collections;

public class creatEnemy : MonoBehaviour {
	float height = 0;
	float width = 0;

	private int randy;
	private int mrandy;

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
		height = this.GetComponentInParent<Camera>().orthographicSize*2f;
		width = this.GetComponentInParent<Camera>().aspect*height;
		levels[0] = enemy;
		levels[1] = enemy1;
		levels[2] = enemy2;
		levels[3] = enemy3;
		levels[4] = enemy4;
		levels[5] = enemy5;
		levels[6] = enemy6;
	}

	// Update is called once per frame
	void FixedUpdate () {
		mrandy =Random.Range (0, 100);
		if ((mrandy % 2) == 0) {
			this.transform.localPosition = new Vector3 (height+2,Random.Range(-width,width));
		}
		if ((mrandy % 3) == 0) {
			this.transform.localPosition = new Vector3 (-height-2,Random.Range(-width,width));
		}
		randy = Random.Range (0, 400);
		
		if (randy == 1) {
			GameObject Spawn = (GameObject)Instantiate (levels [Random.Range (0, 6)], transform.position, transform.rotation);
		}
	}
}
