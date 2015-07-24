﻿using UnityEngine;
using System.Collections;

public class HitCoinFeedback : MonoBehaviour {
	public int timer = 0;
	void Start () {
		this.GetComponent<Rigidbody2D>().velocity = new Vector3 (UnityEngine.Random.Range (-5.0f, 5.0f), UnityEngine.Random.Range (-5.0f, 5.0f), UnityEngine.Random.Range (-5.0f, 5.0f));
	}
	void Update () {
		if (timer > 100) {
			Destroy (this);
		} else {
			timer++;
		}
	}
}
