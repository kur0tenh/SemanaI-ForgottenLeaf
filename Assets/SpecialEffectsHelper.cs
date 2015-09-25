using UnityEngine;
using System.Collections;

public class SpecialEffectsHelper : MonoBehaviour {

	public static SpecialEffectsHelper Instance;
	
	public ParticleSystem explosisonEffect;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");
		}
		
		Instance = this;
	}

	public void Explosion(Vector3 position)
	{
		instantiate(explosisonEffect, position);
	}
	

	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position){
		ParticleSystem newParticleSystem = Instantiate(prefab,position,Quaternion.identity) as ParticleSystem;

		Destroy(newParticleSystem.gameObject,newParticleSystem.startLifetime);
		
		return newParticleSystem;
	}
}