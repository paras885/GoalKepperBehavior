using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallImpl : Ball {
	private Location currentLocation;
	private Velocity currentVelocity;

	public Location getCurrentLocation () {
		return currentLocation;
	}
		
	public Velocity getCurrentVelocity () {
		return currentVelocity;
	}

	public void setCurrentLocation (Location location) {
		this.currentLocation = location;
	}

	public void setCurrentVelocity (Velocity velocity) {
		this.currentVelocity = velocity;
	}
}
