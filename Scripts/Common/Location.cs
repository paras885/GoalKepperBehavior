using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location {
	private float _x;
	private float _y;

	public Location(float x, float y) {
		this._x = x;
		this._y = y;
	}

	public float x {
		get{ return _x; }
		set{ this._x = value; }
	}
	public float y {
		get{ return _y; }
		set{ this._y = value; }
	}

	public string toString() {
		return string.Format ("x: {0}, y: {1}", _x, _y);
	}
}
