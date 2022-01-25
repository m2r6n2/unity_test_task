using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cue : MonoBehaviour
{
    public GameObject kickobj;
    public float Power = 100;
    public TrajectoryRender Trajectory;     // link to TrajectoryRender
    private void Update()
    {
        float enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);     // Creates a ray starting at origin along direction.
        new Plane(-Vector3.forward, transform.position) * Power;
            Vector3 mouseInWorld = ray.GetPoint(enter);
        Vector3 speed = (mouseInWorld - transform.position) * Power;
            Trajectory.ShowTrajectory(transform.position, speed);       // position and speed

    }
}
