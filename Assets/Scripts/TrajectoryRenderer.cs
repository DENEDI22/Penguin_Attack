using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
	[SerializeField] private LineRenderer lineRendererComponent;
	[SerializeField] private Transform aimPointProjector;
	
	
	
	public void ShowTrajectory(Vector3 origin, Vector3 speed)
	{
		Vector3[] points = new Vector3[100];
		lineRendererComponent.positionCount = points.Length;

		for (int i = 0; i < points.Length; i++)
		{
			float time = i * 0.05f;

			points[i] = origin + speed * time + Physics.gravity * (time * time) / 2f;
			
			if (Physics.CheckSphere(points[i], 0.1f))
			{
				lineRendererComponent.positionCount = i + 1;
				aimPointProjector.position = points[i] + Vector3.up;
				break;
			}

			if (points[i].y < 0)
			{
				lineRendererComponent.positionCount = i + 1;
				break;
			}
		}

		lineRendererComponent.SetPositions(points);
	}
}