using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
   public float _speed = 12f;

    private CharacterController _controller;
    private PlayerInput _playerInput;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update ()
    {
        Vector3 move = (transform.right * _playerInput.Horizontal) + transform.forward;
        _controller.Move(move * _speed * Time.deltaTime);
    }

    public void ChangeSpeed(float speed )
	{
        _speed = speed;

    }
}
