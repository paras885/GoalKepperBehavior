using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Ball {
	
	Location getCurrentLocation ();
	Velocity getCurrentVelocity ();
	void setCurrentLocation (Location location);
	void setCurrentVelocity (Velocity velocity);
}