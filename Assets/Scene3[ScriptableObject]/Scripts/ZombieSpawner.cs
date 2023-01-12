using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZombieType { Normal, Power, Sensor, Speed, Tanker, Count }

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private List<ZombieData> zombieDatas;
    [SerializeField]
    private GameObject zombiePrefab;

    private void Start()
    {
        for (int i = 0; i < zombieDatas.Count; i++)
        {
            var zombie = SpawnZombie((ZombieType)i);
            zombie.PrintZombieData();
        }
    }

    public Zombie SpawnZombie(ZombieType type)
    {
        var newZombie = Instantiate(zombiePrefab).GetComponent<Zombie>();
        newZombie.zombieData = zombieDatas[(int)type];
        newZombie.name = newZombie.zombieData.ZombieName;
        return newZombie;
    }
}
