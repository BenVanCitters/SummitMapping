using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	Light myLight;
	// Use this for initialization
	void Start () {
		myLight = gameObject.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		myLight.transform.Rotate (new Vector3 (0.1f, 0f, 0f));
	}
}
