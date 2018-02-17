using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Player {
	
	Location getCurrentLocation ();
	float getCurrentSpeed ();
	float getMaxSpeed ();
	void setCurrentLocation (Location location);
	void setCurrentSpeed (float speed);
}