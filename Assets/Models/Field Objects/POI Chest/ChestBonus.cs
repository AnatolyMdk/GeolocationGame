using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBonus : MonoBehaviour
{
    [SerializeField] private int bonus = 1;

    private void OnMouseDown()
    {
        GameManager.Instance.CurrentPlayer.AddChest(bonus);
        Destroy(gameObject);
    }
}
