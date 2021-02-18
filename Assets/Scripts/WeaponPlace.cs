using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponPlace : MonoBehaviour
{
	[SerializeField] private PlayerController m_currentPlayer;
	[SerializeField] private Weapon[] weapons;
	[SerializeField] private Weapon m_currentWeapon;
	[SerializeField] private GameObject canvas;

	private void OnTriggerEnter(Collider other)
	{
		if (m_currentPlayer == null && other.TryGetComponent<PlayerController>(out m_currentPlayer))
		{
			m_currentPlayer = other.GetComponent<PlayerController>();
			if (m_currentWeapon)
			{
				m_currentWeapon.Enable();
				m_currentPlayer.currentWeaponPlace = this;
				canvas.SetActive(true);
			}
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		PlayerController otherPC;
		if (other.TryGetComponent<PlayerController>(out otherPC) & otherPC == m_currentPlayer)
		{
			if (m_currentWeapon)
			{
				m_currentWeapon.Disable();
				m_currentPlayer.currentWeaponPlace = null;
				m_currentPlayer = null;
				canvas.SetActive(false);
			}
		}
	}
	
	public void RotateWeapon(Vector2 _rotationEuler)
	{
		m_currentWeapon.Rotate(_rotationEuler);
	}

	public void Shoot()
	{
		m_currentWeapon.Shoot();
	}
}

