using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollower : MonoBehaviour
{
    public Transform target;
    public float rotationFollowSpeed;

    private void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationFollowSpeed * Time.deltaTime);
    }
}
