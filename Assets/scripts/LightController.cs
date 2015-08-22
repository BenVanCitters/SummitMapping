using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Utility;
public class LightController : MonoBehaviour {

	Light myLight;
	private MouseLook m_MouseLook;
	// Use this for initialization
	void Start () {
		myLight = gameObject.GetComponent<Light> ();
		m_MouseLook.Init(transform , myLight.transform);
	}
	
	// Update is called once per frame
	void Update () {
		// Read input
		m_MouseLook.LookRotation (transform, myLight.transform);
	}
}
