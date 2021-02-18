using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
	private void OnCollisionEnter(Collision other)
	{
		other.gameObject.SendMessage("OnBulletHit", SendMessageOptions.DontRequireReceiver);
		Destroy(gameObject);
	}
}