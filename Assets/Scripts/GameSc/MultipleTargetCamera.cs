using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MultipleTargetCamera : MonoBehaviour
{
    public List<Transform> targets;

    public float smoothTime = .5f;
    public float minZoom = 25f;
    public float maxZoom = 5f;
    public float zoomLimiter = 50f;

    private Vector2 Velocity;
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
        //Vector3 pos = transform.position; Sitai galima padaryti naudojant offset Move funkcijoj
        //pos.z = posZ;
        float zoom = Mathf.Lerp(maxZoom,minZoom,GetGreatestDistance()/zoomLimiter);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoom, Time.deltaTime);
        //if (cam.orthographicSize <= minZoom)
           // cam.orthographicSize = minZoom; Sitai nebutina kai naudoji Mathf.Lerp() nes jis uztikrina kad nebutu didesnis ar mazesnis
        //transform.position = pos;

    }
    void Move()
    {
        //Vector3 centerPoint = GetCenterPoint(); Situ naudoti neverta nes galima tiesiog tiesiai i apskaiciavima
        //Vector3 newPosition = centerPoint;
        transform.position = Vector2.SmoothDamp(transform.position, GetCenterPoint(), ref Velocity, smoothTime);
    }
    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return Mathf.Sqrt(Mathf.Pow(bounds.size.x,2) + Mathf.Pow(bounds.size.y, 2)); // Sitai naudoju nes reikia ne horizontalaus atsumo o vektoriaus ilgio kuri dar ismoksit
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