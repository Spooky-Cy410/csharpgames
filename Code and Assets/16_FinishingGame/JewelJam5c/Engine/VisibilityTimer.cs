﻿using Microsoft.Xna.Framework;

/// <summary>
/// An object that can make another object visible for a certain amount of time.
/// </summary>
class VisibilityTimer : GameObject
{
    GameObject target;
    float timeLeft;

    public VisibilityTimer(GameObject target)
    {
        timeLeft = 0;
        this.target = target;
    }

    public override void Update(GameTime gameTime)
    {
        // if the timer has already passed earlier, don't do anything
        if (timeLeft <= 0)
            return;

        // decrease the timer by the time that has passed since the last frame
        timeLeft -= (float)gameTime.ElapsedGameTime.TotalSeconds;

        // if enough time has passed, make the target object invisible
        if (timeLeft <= 0)
            target.Visible = false;
    }
    
    /// <summary>
    /// Makes the target object visible, and starts a timer for the specified number of seconds.
    /// </summary>
    /// <param name="seconds">How long the target object should be visible.</param>
    public void StartVisible(float seconds)
    {
        timeLeft = seconds;
        target.Visible = true;
    }
}
