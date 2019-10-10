using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultipleTargetCamera : MonoBehaviour
{
    public List<Transform> targets;

    public Vector3 offset;

    public float smoothTime = .5f;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic

    public float minZoom = 50f;

    public float maxZoom = 20f;
    public float minZ = -5f;
    public float zoomLimiter = 20f;
<<<<<<< HEAD
<<<<<<< HEAD
=======
    public float minZoom = 3f;
    public float posZ = -10f;
>>>>>>> parent of 229c4fc... Camera
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic

    private Vector3 Velocity;
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }
    void LateUpdate()
    {
        if (targets.Count == 0)
            return;
        Move();
        Zoom();
    }
    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
<<<<<<< HEAD
<<<<<<< HEAD
        cam.orthographicSize = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
        Vector3 pos = transform.position;
        pos.z = -10;
        if (cam.orthographicSize <= cam.orthographicSize)
            cam.orthographicSize = GetGreatestDistance() + smoothTime + 10;
=======
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
        Vector3 pos = transform.position;
        pos.z = -25;
        if (cam.fieldOfView <= cam.fieldOfView)
            cam.fieldOfView = GetGreatestDistance() + smoothTime + 10;
<<<<<<< HEAD
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic
=======
>>>>>>> parent of 7d87e73... Camera pakeista is Perspective i Orthographic
        transform.position = pos;

    }
    void Move()
    {

        Vector3 centerPoint = GetCenterPoint();
        Vector3 newPosition = centerPoint;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref Velocity, smoothTime);
    }
    float GetGreatestDistance()
  {
       var bounds = new Bounds(targets[0].position, Vector3.zero);
       for (int i = 0; i < targets.Count; i++)
        {
           bounds.Encapsulate(targets[i].position);
       }
     return bounds.size.x;
    }
    Vector3 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }

}