using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
	[SerializeField] private GameObject _enemyPrefab;
	[SerializeField] private Transform[] _spawnPoints;
	[SerializeField] private float _SecondsBetweenSpawn;
	[SerializeField] private Transform _player;

	private float _elapsedTime = 0f;

	private void Start ( )
	{
		Initialize(_enemyPrefab);
	}

	private void Update ( )
	{
		_elapsedTime += Time.deltaTime;

		if (_elapsedTime >= _SecondsBetweenSpawn)
		{
			if (TryGetObject(out GameObject enemy))
			{
				_elapsedTime = 0f;

				int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
				Vector3 spawnPosition = new Vector3(_spawnPoints[spawnPointNumber].position.x, _spawnPoints[spawnPointNumber].position.y, _spawnPoints[spawnPointNumber].position.z + _player.position.z);
				SetEnemy(enemy, spawnPosition);
			}

		}
	}

	private void SetEnemy(GameObject enemy, Vector3 spawnpoint)
	{
		enemy.SetActive(true);
		enemy.transform.position = spawnpoint;

	}
}
