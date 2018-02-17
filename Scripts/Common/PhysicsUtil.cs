using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsUtil {

	private static PhysicsUtil INSTANCE = null;

	public PhysicsUtil() {
		if (INSTANCE == null || INSTANCE != this) {
			INSTANCE = this;
		}
	}

	public Location getNextLocationByCurrentLocationAndVelocity(
		Location currentLocation, Velocity velocity) {
		return new Location (currentLocation.x + velocity.vector.x, 
			currentLocation.y + velocity.vector.y);
	}
}
