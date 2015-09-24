using UnityEngine;
using System.Collections;

public class creatEnemy : MonoBehaviour {
	float height = 0;
	float width = 0;
	public int maximo=50;
	private int randy;
	private int mrandy;
	private int superRandy;
	public GameObject enemy;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	public GameObject enemy6;
	public int probabilidad;
	public ArrayList alist;
	private int contador;
	private GameObject contual;
	GameObject[] levels = new GameObject[7]; 
	// Use this for initialization
	void Start () {
		contador = 0 ;
		LifeBasics.cont = 0;
		probabilidad = 400;
		height = this.GetComponentInParent<Camera>().orthographicSize;
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
		Debug.Log ("PROBA  "+probabilidad);
		if (contador >= 70) {
			probabilidad--;
			contador =0;
		}
		else
		contador++;
		Invoke ("Spawn", 3f);
		Debug.Log(""+LifeBasics.cont);
	}
	void Spawn(){
			float riri;
			superRandy = Random.Range (0, 2);
			mrandy = Random.Range (0, 100);
			randy = Random.Range (0, probabilidad);
			if (superRandy == 0) {
				riri = Random.Range (-height / 2, height / 2);
				if ((mrandy % 2) == 0) {
					this.transform.localPosition = new Vector3 (width, riri);
					if (randy == 1) {
						//GameObject Spawn = (GameObject)Instantiate (levels [Random.Range (0, 6)], transform.position, transform.rotation);
					if (maximo >= LifeBasics.cont){ 
						LifeBasics.cont++;
						Instantiate (levels [Random.Range (0, 6)], new Vector3 (this.transform.position.x, this.transform.position.y, 0), this.transform.rotation);
					}
					}
				}
				if ((mrandy % 2) != 0) {
					this.transform.localPosition = new Vector3 (-width, riri);
					if (randy == 1) {
						//GameObject Spawn = (GameObject)Instantiate (levels [Random.Range (0, 6)], transform.position, transform.rotation);
					if (maximo >= LifeBasics.cont){ 
						LifeBasics.cont++;
						Instantiate (levels [Random.Range (0, 6)], new Vector3 (this.transform.position.x, this.transform.position.y, 0), this.transform.rotation);
					}
					}
				}
			} else {
				riri = Random.Range (-width / 2, width / 2);
				if ((mrandy % 2) == 0) {
					this.transform.localPosition = new Vector3 (riri, height);
					if (randy == 1) {
					if (maximo >= LifeBasics.cont){
						LifeBasics.cont++;
						Instantiate (levels [Random.Range (0, 6)], new Vector3 (this.transform.position.x, this.transform.position.y, 0), this.transform.rotation);
					}
					}
				}
				if ((mrandy % 2) != 0) {
					this.transform.localPosition = new Vector3 (riri, -height);
					if (randy == 1) {
					if (maximo >= LifeBasics.cont){
						LifeBasics.cont++;
						Instantiate (levels [Random.Range (0, 6)], new Vector3 (this.transform.position.x, this.transform.position.y, 0), this.transform.rotation);
					}
				}
				}
			}
		}
	}

