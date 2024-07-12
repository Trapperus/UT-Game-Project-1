using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollower : MonoBehaviour
{
    public Transform target;
    public float rotationFollowSpeed;

    private void LateUpdate()
    {
        //Sets the weapon position to the target position
        transform.position = target.position;

        //Moves the weapon rotation smoothly to the targets rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotationFollowSpeed * Time.deltaTime);
    }
}
