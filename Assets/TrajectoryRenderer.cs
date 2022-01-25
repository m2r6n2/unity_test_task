using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    private LineRenderer lineRendererComponent;     //   cache link to renderer
    void Start()
    {
        lineRendererComponent = GetComponent<lineRendererComponent>();      //  method for drawing the trajectory

    }
    public void Showtrajectory(Vector3 origin, Vector3 speed)       //takes position from where and what speed
    {
        Vector3[] points = new Vector3[100];        //assign a vector of points
        lineRendererComponent.positionCount = points.Length;               

        for (int i = 0; i < points.Length; i++)     //assignment formulа array
        {
            float time = i * 0.1f;
            points[i] = origin + speed * time + Physics.gravity * time * time / 2f;
        }
        lineRendererComponent.SetPosition(points);      // pass an array 
    }
}
