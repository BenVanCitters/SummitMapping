using UnityEngine;
using System.Collections;

public class MoviePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Projector p = gameObject.GetComponent<Projector> ();
//		Material material = gameObject.GetComponent<Material> ();
		if (p != null) 
		{
//			MovieTexture m = p.material.GetTexture("_ShadowTex") as MovieTexture; //mainTexture as MovieTexture;
//			m.loop = true;
//			m.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
