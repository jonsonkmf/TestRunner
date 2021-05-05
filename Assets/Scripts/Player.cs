using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private int _maxHealth = 100;

	public int _currentHealth;

	private void Start ( )
	{
		_currentHealth = _maxHealth;
	}

	public void ApplyDamage(int damage )
	{
		_currentHealth -= damage;

		if (_currentHealth<=0)
		{
			Die();
		}
	}

	private void Die ( )
	{
		Destroy(gameObject);
		Time.timeScale = 0;
	}
}
