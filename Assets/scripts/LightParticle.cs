using UnityEngine;
using System.Collections;

public class LightParticle : MonoBehaviour {


	void Start () {
	
	}

	void OnCollisionEnter(Collision collision) {

		if(collision.collider.CompareTag("LightCatcher"))
		{
			Destroy(this.gameObject);
//			Debug.
		}
	}
}
