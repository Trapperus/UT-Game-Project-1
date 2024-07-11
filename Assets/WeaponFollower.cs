using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollower : MonoBehaviour
{
    public Transform target;
    public float followSpeed;

    private void Update()
    {
        transform.position = target.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, followSpeed * Time.deltaTime);
    }
}
