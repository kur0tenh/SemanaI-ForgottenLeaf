using UnityEngine;
using System.Collections;

public class SoundEffectsHelper1 : MonoBehaviour
{

	public static SoundEffectsHelper1 Instance;

	public AudioClip shootsound;

	//instancia el sonido
	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	//Genera el sonido del salto
	public void makeShootingSound()
	{
		MakeSound (shootsound);	
	}
	
	
	//Esta funcion hace que el clip de audio suene
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}


