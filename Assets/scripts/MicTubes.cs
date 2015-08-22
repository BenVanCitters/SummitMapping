using UnityEngine;
using System.Collections;

public class MicTubes : MonoBehaviour 
{
	ArrayList tubes;
	AudioClip currentClip;
	float minZ = float.MaxValue;
	float maxZ = float.MinValue;
	// Use this for initialization
	void Start () 
	{
		initTubesArrayList ();
		AudioSource aud = GetComponent<AudioSource>();
		currentClip = Microphone.Start("Built-in Microphone", true, 10, 44100);
	
	}

	void initTubesArrayList()
	{
		tubes = new ArrayList ();
		//Tube array
		foreach (Transform tbAr in transform) {
			//actual tube
			foreach (Transform tb in tbAr) {
				tubes.Add(tb.gameObject);
			}
			tubes.Remove(tbAr.gameObject);
		}
		tubes.Remove(this.gameObject);
		Debug.Log ("tube count: " + tubes.Count);
	}

	// Update is called once per frame
	void Update () 
	{
//		float amt = CrossPlatformInputManager.GetAxis("axis3")*.2f;
		float[] samples = new float[currentClip.samples * currentClip.channels];
		currentClip.GetData(samples, 0);

		float zScale = transform.localScale.z;
		Vector3 localPos = transform.position;
		int currentPos = Microphone.GetPosition ("");

		for(int i = 0; i < tubes.Count; i++)
		{
			GameObject g = (GameObject)tubes[i];
			int sampleIndex = (currentPos-i+samples.Length)%samples.Length;
			Vector3 newPos = g.transform.localPosition;
			newPos.z = 20*samples[sampleIndex]/zScale ;
			g.transform.localPosition= newPos;
//			g.transform.position = newPos;
//			maxZ = Mathf.Max(maxZ,g.transform.position.z);
//			minZ = Mathf.Min(minZ,g.transform.position.z);
		}
//		Debug.Log("min/max: " + minZ + "," + maxZ);
	}
}
