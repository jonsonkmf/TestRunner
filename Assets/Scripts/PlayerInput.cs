using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	public float Horizontal { get; private set; }

	private void Update ( )
	{
		Horizontal = Input.GetAxis("Horizontal");
	}
}
