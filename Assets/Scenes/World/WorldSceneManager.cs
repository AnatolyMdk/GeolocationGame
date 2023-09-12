using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : GameSceneManager
{
    public override void playerTapped(GameObject player) {
        
    }

    public override void RobotTapped(GameObject robot) {
        Debug.Log("Robot tapped");
        SceneManager.LoadScene(GameConstants.SCENE_CAPTURE, LoadSceneMode.Additive);
    }
}
