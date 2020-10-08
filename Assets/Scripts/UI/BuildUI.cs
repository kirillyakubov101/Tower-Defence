using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUI : MonoBehaviour
{
	[SerializeField] LayerMask towerMask;

	private void Update()
	{
		if(Input.GetMouseButtonDown(1))
		{
			RaycastHit hit;
			bool hasHit = Physics.Raycast(GetMouseRay(), out hit, towerMask);
			if (hasHit)
			{
	
			}
			
		}
	}

	private Ray GetMouseRay()
	{
		return Camera.main.ScreenPointToRay(MousePos());
	}

	private Vector3 MousePos()
	{
		return Input.mousePosition;
	}


}
