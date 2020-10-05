using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class EmpySlot : MonoBehaviour
{
	[SerializeField] Tower tower;
	[SerializeField] int towerPrice = 100;
	Vector3 newTowerPos;
	LevelController levelController;

	private void Awake()
	{
		levelController = FindObjectOfType<LevelController>();
	}

	private void Start()
	{
		newTowerPos = new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z);
	}

	private void OnMouseUpAsButton()
	{
		if(levelController.GetGoldAmount() >= towerPrice)
		{
			levelController.PayForTower(towerPrice);
			Instantiate(tower, newTowerPos, transform.rotation);
			Destroy(gameObject);
		}
		
	}
}
