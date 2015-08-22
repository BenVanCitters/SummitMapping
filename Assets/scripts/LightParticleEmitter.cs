using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class LightParticleEmitter : MonoBehaviour 
{
	public GameObject lightParticlePrefab;
	// Use this for initialization
	void Start () 
	{
	
	}



	// Update is called once per frame
	void Update () {
		//CrossPlatformInputManager.GetAxis("Horizontal");
		bool genLight = CrossPlatformInputManager.GetButton("Fire1"); 
		if(genLight)
		{
			Instantiate(lightParticlePrefab, gameObject.transform.position+ new Vector3(0,0,-6),Quaternion.identity);
		}
	}
}
