using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class RobotFactory : Singleton<RobotFactory>
{
    [SerializeField] private Robot[] AvailableRobots;
    [SerializeField] private float WaitTime = 180.0f;
    [SerializeField] private int StartingRobots = 5;
    [SerializeField] private float MinRange = 5.0f;
    [SerializeField] private float MaxRange = 50.0f;
    
    private List<Robot> LiveRobots = new List<Robot>();
    private Robot SelectedRobot;
    private Player Player;

    public List<Robot> LiveRobots_
    {
        get { return LiveRobots; }
    }

    public Robot SelectedRobot_
    {
        get { return SelectedRobot; }
    }


    private void Awake()
    {
        Assert.IsNotNull(AvailableRobots);
    }


    void Start()
    {
        Player = GameManager.Instance.CurrentPlayer;
        Assert.IsNotNull(Player);

        for (int i = 0; i < StartingRobots; i++)
        {
            InstantiateRobot();
        }

        StartCoroutine(GenerateRobots());
    }

    private IEnumerator GenerateRobots()
    {
        while (true)
        {
            InstantiateRobot();
            yield return new WaitForSeconds(WaitTime);
        }
    }

    public void DroidWasSelected(Robot robot)
    {
        SelectedRobot = robot;
    }

    private void InstantiateRobot()
    {
        int index = Random.Range(0, AvailableRobots.Length);
        float x = Player.transform.position.x + GenerateRange();
        float y = Player.transform.position.y;
        float z = Player.transform.position.z + GenerateRange();

        LiveRobots.Add(Instantiate(AvailableRobots[index], new Vector3(x, y, z), Quaternion.identity));

    }

    private float GenerateRange()
    {
        float RandomNum = Random.Range(MinRange, MaxRange);
        bool IsPositive = Random.Range(0, 10) < 5;
        return RandomNum * (IsPositive ? 1 : -1);
    }
}
