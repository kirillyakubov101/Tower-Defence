using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
	[SerializeField] int lives = 20;
	[SerializeField] int gold = 200;
	[SerializeField] Text goldPoints;
	[SerializeField] Text lifePoints;


	bool hasLost = false;

	private void Awake()
	{

	}

	private void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
    {
		goldPoints.text = gold.ToString();
		lifePoints.text = lives.ToString(); //FIX THIS

		if (hasLost)
		{

			//Time.timeScale = 0f;
		}
		CheckIfLost();

	}

	private void LoseLifePoint()
	{
		lives--;
	}

	private void CheckIfLost()
	{
		if (lives <= 0)
		{
			hasLost = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			LoseLifePoint();
			Destroy(other.gameObject);
		}
	}

	public void GainGold(int goldAmount)
	{
		gold += goldAmount;
	}

	public void PayForTower(int price)
	{
		gold -= price;
	}

	public int GetGoldAmount()
	{
		return gold;
	}
}
