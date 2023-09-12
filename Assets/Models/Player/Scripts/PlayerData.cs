using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    private int xp;
    private int requiredXp;
    private int levelBase;
    private int lvl;
    private List<RobotData> robots;

    public int Xp { get { return xp; } }
    public int RequiredXp { get { return requiredXp; } }
    public int LevelBase { get { return levelBase; } }
    public int Lvl { get { return lvl; } }
    public List<RobotData> Robots { get { return robots; } }

    public PlayerData(Player player)
    {
        xp = player.Xp;
        requiredXp = player.RequiredXp;
        levelBase = player.LevelBase;
        lvl = player.Lvl;
        
        foreach(GameObject robotObject in player.Robots)
        {
            Robot robot = robotObject.GetComponent<Robot>();
            if (robot != null)
            {
                RobotData data = new RobotData(robot);
                robots.Add(data);
            }
        }
    }
}
