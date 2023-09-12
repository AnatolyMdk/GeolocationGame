using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RobotData
{
    private float spawnRate;
    private float catchRate;
    private int attack;
    private int defense;
    private int hp;

    public float SpawnRate { get { return spawnRate; } }
    public float CatchRate { get { return catchRate; } }
    public int Attack { get { return attack; } }
    public int  Defense { get { return defense; } }
    public int Hp { get { return hp; } }

    public RobotData(Robot robot)
    {
        spawnRate = robot.SpawnRate;
        catchRate = robot.CatchRate;
        attack = robot.Attack;
        defense = robot.Defense;
        hp = robot.Hp;
    }
}
