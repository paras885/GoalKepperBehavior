using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollider : MonoBehaviour {
	public bool isCollide = false;

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "GoalKepper" || collision.gameObject.name == "GoalPost") {
			isCollide = true;
		}
	}
}
