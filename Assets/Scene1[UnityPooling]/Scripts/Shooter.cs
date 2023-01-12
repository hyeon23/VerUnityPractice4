using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject _BulletPrefab;

    private Camera _MainCam;

    private IObjectPool<Bullet> _Pool;

    private void Awake()
    {
        _Pool = new ObjectPool<Bullet>(CreateBullet, OnGetBullet, OnReleaseBullet, OnDestroyBullet, maxSize: 20);
    }

    private Bullet CreateBullet()
    {
        Bullet bullet = Instantiate(_BulletPrefab).GetComponent<Bullet>();
        bullet.setManagedPool(_Pool);
        return bullet;
    }

    //풀 -> 오브젝트 대출
    private void OnGetBullet(Bullet bullet)
    {
        bullet.gameObject.SetActive(true);
    }

    //오브젝트 -> 풀 반환
    private void OnReleaseBullet(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    //풀에서 오브젝트 파괴 시, 사용
    private void OnDestroyBullet(Bullet bullet)
    {
        Destroy(bullet.gameObject);
    }


    void Start()
    {
        _MainCam = Camera.main;
    } 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hitResult;
            if(Physics.Raycast(_MainCam.ScreenPointToRay(Input.mousePosition), out hitResult))
            {
                var direction = new Vector3(hitResult.point.x, transform.position.y, hitResult.point.z) - transform.position;
                // 총알을 새로 생성해서 사용
                //var bullet = Instantiate(_BulletPrefab, transform.position + direction.normalized, Quaternion.identity).GetComponent<Bullet>();
                var bullet = _Pool.Get();//실제 총알 생성 or 사용
                bullet.transform.position = transform.position + direction.normalized;
                bullet.Shoot(direction.normalized);
            }
        }
    }
}
