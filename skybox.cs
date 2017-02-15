using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class skybox : MonoBehaviour {

	public Material[] secondSkybox;
	public static int i = 0;
	public void skyboxOn()
	{

		if (i == 0) {

		RenderSettings.skybox = secondSkybox[0];
			i++;
		}
		else if(i==1)
		{
			RenderSettings.skybox = secondSkybox[1];
			i++;
		}else if(i==2)
		{
			RenderSettings.skybox = secondSkybox[2];
			i=0;
		}



	}
}

