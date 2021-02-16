using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	[SerializeField] private float velocity;
	[Header("GlobalGUI")]
	[SerializeField] private GameObject pauseMenu;
	private Rigidbody playerRb;
	[SerializeField] private PlayerInput m_playerInput;

	private void Awake()
	{
		playerRb = GetComponent<Rigidbody>();
		m_playerInput = GetComponent<PlayerInput>();
	}

	public void OnPause()
	{
		pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
		m_playerInput.SwitchCurrentActionMap(pauseMenu.activeInHierarchy ?"UI" : "CharacterMoving");
	}

	
	
	public void OnMovement()
	{
		var _movementVector = m_playerInput.actions.FindAction("Movement").ReadValue<Vector2>();
		Vector3 movementVector3 = new Vector3(_movementVector.x,0, _movementVector.y);
		playerRb.velocity = (movementVector3 * velocity) + new Vector3(0, playerRb.velocity.y, 0);
	}
}
