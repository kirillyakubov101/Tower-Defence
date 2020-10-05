using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField] WaveConfig wave;
	[SerializeField] Transform target;

	// Start is called before the first frame update
	void Start()
	{
		StartCoroutine(SpawnAllEnemiesInWave(wave));
	}

	private IEnumerator SpawnAllEnemiesInWave(WaveConfig wave)
	{
		for (int enemyCount = 0; enemyCount < wave.NumberOfEnemies(); enemyCount++)
		{
			Instantiate(wave.GetEnemyPrefab(), transform.position, Quaternion.identity);
			yield return new WaitForSeconds(wave.TimeBetweenSpawn());
		}
	}

	public Transform GetTarget()
	{
		return target;
	}

}
