using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GoalPost {

	Location getBottomLeft ();
	Location getBottomRight ();
	void setBottomLeft (Location location);
	void setBottomRight (Location location);
}