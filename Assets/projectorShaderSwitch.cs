using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class projectorShaderSwitch : MonoBehaviour {
	private bool isMult = false;

	public Material projectorMaterial;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		CrossPlatformInputManager.GetButtonUp
			if(CrossPlatformInputManager.GetButtonUp ("SwapShader"))
		{
			if(isMult)
			{
				projectorMaterial.shader = Shader.Find("Projector/Light");
				RenderSettings.ambientLight = Color.black;
				RenderSettings.ambientIntensity = 0;
			}
			else
			{
				projectorMaterial.shader = Shader.Find("Projector/Multiply");
				RenderSettings.ambientLight = Color.white;
				RenderSettings.ambientIntensity = 1;
			}
			isMult = !isMult;
		}
	}
}
