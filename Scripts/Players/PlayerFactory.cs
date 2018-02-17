using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFactory {
	public Player getPlayer(PlayerType.TYPE type) {
		Player player = null;
		if (type.Equals (PlayerType.TYPE.GoalKepper)) {
			player = new GoalKepperImpl ();
		}
		return player;
	}
}