using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    [SerializeField]
    Rigidbody fallRigid;

    private void OnTriggerEnter(Collider other)
    {
        fallRigid.useGravity = true;
    }
}
