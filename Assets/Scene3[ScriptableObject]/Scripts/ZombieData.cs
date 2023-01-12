using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1. Scriptable Object 생성법
[CreateAssetMenu(fileName = "Zombie Data", menuName = "Scriptable Object/Zombie", order = int.MaxValue)]//해당 Attribute는 ScriptableObject를 상속받는 클래스를 ScriptableObject Asset으로 만들어줌
//fileName: 생성된 ScriptableObject Asset의 이름을 정함
//MenuName: scriptableObject를 생성하는 메뉴의 이름을 정함
//Order: Create Menu들 중에서 몇번째 위치에서 표시할 것인지 정하는 매개변수

public class ZombieData : ScriptableObject
{
    [SerializeField]
    private string zombieName;
    public string ZombieName { get { return zombieName; } }

    [SerializeField]
    private int hp;
    public int HP { get { return hp; } }
    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }

    [SerializeField]
    private float sightRange;
    public float SightRange { get { return sightRange; } }

    [SerializeField]
    private float moveSpeed;
    public float MoveSpeed { get { return moveSpeed; } }
}
