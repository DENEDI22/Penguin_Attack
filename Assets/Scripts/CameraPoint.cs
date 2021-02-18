using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint : MonoBehaviour
{
	[SerializeField] private Vector3 cameraOffset;

	private bool followCamera = true;
	private GameObject[] players = new GameObject[2];
	private Transform camera;
}
