﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour
{
	public void OnBulletHit()
	{
		Destroy(gameObject);
	}
}
