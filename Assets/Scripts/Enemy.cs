using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] int _damage = 10;

	private void OnTriggerEnter ( Collider other )
	{
		var player = other.GetComponent<Player>();
		if (player!=null)
		{
			player.ApplyDamage(_damage);
		}

		Die();
	}

	private void Die ( )
	{
		gameObject.SetActive(false);
	}
}
