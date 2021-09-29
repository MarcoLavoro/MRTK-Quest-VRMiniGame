using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPoseOnFall : MonoBehaviour
{
    private Pose startingPose;
    private Rigidbody rigidbody;
    void Start()
    {
        startingPose = new Pose(this.transform.position, this.transform.rotation);
        rigidbody = this.GetComponent<Rigidbody>();
    }
    public void ResetPose()
    {
        this.transform.position = startingPose.position;
        this.transform.rotation = startingPose.rotation;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.velocity = Vector3.zero;
    }
}
