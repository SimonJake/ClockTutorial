﻿using UnityEngine;
using System.Collections;

public class clock : MonoBehaviour {

	void Update() {
		Quaternion euler = Quaternion.Euler (
			                   new Vector3 (0f, 0f, Time.time * 360f));
		transform.localRotation = euler;
	}

}
