using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class QualityChanger : MonoBehaviour
{
	private GameObject m_DXRVolume;

	private void Awake()
	{
		m_DXRVolume = GameObject.Find("DXR Settings Volume");
	}

	public void SwitchDXR(TextMeshProUGUI _textMeshPro)
	{
		m_DXRVolume.SetActive(!m_DXRVolume.activeInHierarchy);
		_textMeshPro.text = m_DXRVolume.activeInHierarchy ? "RTX on" : "RTX off";
	}
}
