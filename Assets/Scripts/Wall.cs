using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
	[SerializeField] private int _damage = 1;
	[SerializeField] private float _secondsBetweenTakeDamage = 1f;

	private float timer = 0f;

	private void OnCollisionEnter ( Collision collision )
	{
		var player = collision.collider.GetComponent<Player>();
		if (player != null)
		{
			player.ApplyDamage(_damage);
		}

	}

	private void OnCollisionStay ( Collision collision )
	{
		var player = collision.collider.GetComponent<Player>();
		timer += Time.deltaTime;
		if (player != null && timer>_secondsBetweenTakeDamage)
		{
			player.ApplyDamage(_damage);
			timer = 0f;
		}

	}

}
