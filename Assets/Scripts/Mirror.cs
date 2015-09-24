using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour {
	float dangle = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D bam){
		if (bam.gameObject.GetComponent<Proyectil> () != null) {

			if(bam.gameObject.GetComponent<Transform>().rotation.z>90&&bam.gameObject.GetComponent<Transform>().rotation.z<270){
				dangle = 180 - (-this.transform.rotation.z - bam.gameObject.transform.rotation.z);
				bam.gameObject.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 0, dangle);
			}
			if(bam.gameObject.GetComponent<Transform>().rotation.z<90&&bam.gameObject.GetComponent<Transform>().rotation.z>270){
				dangle = 180 - (this.transform.rotation.z - bam.gameObject.transform.rotation.z);
				bam.gameObject.GetComponent<Transform> ().rotation = Quaternion.Euler (0, 0, dangle);
			}
		} 
			
	}
}
