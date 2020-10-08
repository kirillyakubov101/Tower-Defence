using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUi : MonoBehaviour
{
	Image buildImage;

	private void Awake()
	{
		buildImage = GetComponent<Image>();
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

	public Image GetBuildUiImage()
	{
		return buildImage;
	}
}
