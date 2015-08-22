using UnityEngine;
using System.Collections;

public class projectorSpinner : MonoBehaviour {
	public Vector3 rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion temp = new Quaternion();
		temp.eulerAngles = new Vector3 (Time.time*rotationSpeed.x,Time.time*rotationSpeed.y,Time.time*rotationSpeed.z);
		transform.rotation = temp;

//		transform.Rotate(n);
	}
}
