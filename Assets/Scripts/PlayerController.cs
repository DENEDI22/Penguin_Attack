using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	[SerializeField] private float velocity;
	private Rigidbody playerRb;

	private void Awake()
	{
		playerRb = GetComponent<Rigidbody>();
	}

	public void Movement(InputAction.CallbackContext _ctx)
	{
		var _movementVector = _ctx.ReadValue<Vector2>();
		Vector3 movementVector3 = new Vector3(_movementVector.x,0, _movementVector.y);
		playerRb.velocity = (movementVector3 * velocity) + new Vector3(0, playerRb.velocity.y, 0);

	}
}
