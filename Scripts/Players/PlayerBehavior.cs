using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlayerBehavior {
	void setField (Field field);
	Location getNextPosition ();
}
