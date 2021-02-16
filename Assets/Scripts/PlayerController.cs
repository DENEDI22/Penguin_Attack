using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
	[SerializeField] private float velocity;
	[SerializeField] private float rotationSpeed = 40f;
	[SerializeField] private GameObject[] playerSkins;
	[Header("GlobalGUI")] [SerializeField] private GameObject pauseMenu;
	private Rigidbody playerRb;
	private PlayerInput m_playerInput;
	private GameManager m_gameManager;
	private bool m_isGamePausedByThisPlayer;
	private float timeScaleBeforePause;
	private void Awake()
	{
		playerRb = GetComponent<Rigidbody>();
		m_playerInput = GetComponent<PlayerInput>();
		m_gameManager = FindObjectOfType<GameManager>();
		playerSkins[m_playerInput.playerIndex].SetActive(true);
	}
	
	public void OnPause()
	{
		if (!m_gameManager.GamePaused)
		{
			pauseMenu.SetActive(true);
			m_playerInput.SwitchCurrentActionMap("UI");
			m_isGamePausedByThisPlayer = true;
			m_gameManager.GamePaused = true;
			timeScaleBeforePause = Time.timeScale;
			Time.timeScale = 0;
		}
		else if (m_isGamePausedByThisPlayer)
		{
			pauseMenu.SetActive(false);
			m_playerInput.SwitchCurrentActionMap("CharacterMoving");
			m_isGamePausedByThisPlayer = false;
			m_gameManager.GamePaused = false;
			Time.timeScale = timeScaleBeforePause;
		}
	}

	private void Update()
	{
		var _movementVector = m_playerInput.actions.FindAction("Movement").ReadValue<Vector2>();
		Vector3 movementVector3 = new Vector3(_movementVector.x, 0, _movementVector.y);
		playerRb.velocity = (movementVector3 * velocity) + new Vector3(0, playerRb.velocity.y, 0);
		if (_movementVector.magnitude > 0.01f)
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementVector3),
				Time.deltaTime * rotationSpeed);
			playerRb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
		}
		else
		{
			playerRb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
		}
	}

	public void OnMovement()
	{
	}
}