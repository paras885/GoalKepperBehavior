using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity {

	private Vector3 _vector;

	public Velocity (Vector3 vector) {
		this._vector = vector;
	}

	public Vector3 vector {
		get{ return _vector; }
	}
}
