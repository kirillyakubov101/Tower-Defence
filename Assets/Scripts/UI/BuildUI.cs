using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUi : MonoBehaviour
{
	[SerializeField] Image buildImage;
	

	
	private void Awake()
	{
		buildImage.enabled = false;
	}


	public void ActivateOnlyOneUiElement()
	{
		BuildUi[] buidUiObjects = FindObjectsOfType<BuildUi>();
		foreach(BuildUi uiElement in buidUiObjects)
		{
			if(this != uiElement)
			{
				uiElement.GetBuildUiImage().enabled = false;
			}
			else
			{
				uiElement.GetBuildUiImage().enabled = true;
			}
		}
	}

	private Image GetBuildUiImage()
	{
		return buildImage;
	}

	
}
