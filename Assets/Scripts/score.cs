using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public static int puntaje =0;
	Text instruction;
	// Use this for initialization
	void Start () {
		instruction = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		instruction.text = "Score: "+puntaje;

	}
}
