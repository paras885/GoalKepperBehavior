using System.Collections;
using UnityEngine;

public interface Field {

	GoalPost getGoalPost ();
	Player getPlayer();
	Ball getBall ();
	int getLength();
	int getWidth();
	Location getNextPositionForBall ();
	void setGoalPost (GoalPost goalPost);
	void setPlayer (Player player);
	void setBall (Ball ball);
	void setLength (int length);
	void setWidth (int width);
}
