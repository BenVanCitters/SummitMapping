using UnityEngine;
using System.Collections;

using UnityStandardAssets.CrossPlatformInput;

public class ProjectorSetController : MonoBehaviour 
{
	private int currentSetIndex = 0;
	// Use this for initialization
	void Start () {

	}

	void activateCurrentChild()
	{
		foreach(Transform t in transform)
		{
			t.gameObject.SetActive(false);
		}
		transform.GetChild(currentSetIndex).gameObject.SetActive(true);
	}

	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButtonUp ("ChangeProjSet"))
		{
			activateCurrentChild();
			currentSetIndex = (currentSetIndex + 1)%transform.childCount;
		}
	}
}
