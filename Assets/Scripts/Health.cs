using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	[SerializeField] float health = 100f;
	[SerializeField] int goldAmount = 50;

	LevelController levelController;

	private void Awake()
	{
		levelController = FindObjectOfType<LevelController>();
	}

	public void takeDamage(float damage)
	{
		if(damage >= health)
		{
			health = 0;
			levelController.GainGold(goldAmount);
			Destroy(gameObject); //die
		}

		health -= damage;

	}
}
