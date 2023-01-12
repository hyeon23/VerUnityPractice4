using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1. Scriptable Object ������
[CreateAssetMenu(fileName = "Zombie Data", menuName = "Scriptable Object/Zombie", order = int.MaxValue)]//�ش� Attribute�� ScriptableObject�� ��ӹ޴� Ŭ������ ScriptableObject Asset���� �������
//fileName: ������ ScriptableObject Asset�� �̸��� ����
//MenuName: scriptableObject�� �����ϴ� �޴��� �̸��� ����
//Order: Create Menu�� �߿��� ���° ��ġ���� ǥ���� ������ ���ϴ� �Ű�����

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
