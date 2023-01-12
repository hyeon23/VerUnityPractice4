 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public ZombieData zombieData;

    public void PrintZombieData()
    {
        Debug.Log("좀비이름 :: " + zombieData.ZombieName);
        Debug.Log("좀비체력 :: " + zombieData.HP);
        Debug.Log("좀비공격력 :: " + zombieData.Damage);
        Debug.Log("좀비시야 :: " + zombieData.SightRange);
        Debug.Log("좀비이동속도 :: " + zombieData.MoveSpeed);
        Debug.Log("----------------------------------------");
    }
}
