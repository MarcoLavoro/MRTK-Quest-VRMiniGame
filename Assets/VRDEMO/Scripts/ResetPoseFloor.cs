using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPoseFloor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        ResetPoseOnFall resetter = collision.gameObject.GetComponent<ResetPoseOnFall>();
        if (resetter != null) resetter.ResetPose();

    }
}
