using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPostImpl : GoalPost {

	private Location bottomLeft;
	private Location bottomRight;

	public Location getBottomLeft () {
		return bottomLeft;
	}
		
	public Location getBottomRight () {
		return bottomRight;
	}

	public void setBottomLeft (Location location) {
		this.bottomLeft = location;
	}

	public void setBottomRight (Location location) {
		this.bottomRight = location;
	}
}