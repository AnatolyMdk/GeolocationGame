﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Robot : MonoBehaviour
{
    [SerializeField] private float spawnRate = 0.10f;
    [SerializeField] private float catchRate = 0.10f;
    [SerializeField] private int attack = 0;
    [SerializeField] private int defense = 0;
    [SerializeField] private int hp = 10;

    public float SpawnRate
    {
        get { return spawnRate; }
    }

    public float CatchRate
    {
        get { return catchRate; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Defense
    {
        get { return defense; }
    }

    public int Hp
    {
        get { return hp; }
    }

    private void OnMouseDown()
    {
        GameSceneManager[] Managers = FindObjectsOfType<GameSceneManager>();
        foreach (GameSceneManager SceneManager in Managers)
        {
            if (SceneManager.gameObject.activeSelf)
            {
                SceneManager.RobotTapped(this.gameObject);
            }
        }
    }
}
