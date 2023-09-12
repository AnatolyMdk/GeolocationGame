using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureSceneManager : GameSceneManager
{
    public override void playerTapped(GameObject player)
    {
        print("CaptureSceneManager.playerTapped activated");
    }

    public override void RobotTapped(GameObject robot)
    {
        print("CaptureSceneManager.RobotTapped activated");
    }
}
