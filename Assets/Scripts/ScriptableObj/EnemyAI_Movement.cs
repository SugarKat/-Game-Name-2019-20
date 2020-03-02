using System.Collections;
using UnityEngine;
using Pathfinding;
using Pathfinding.Util;

[AddComponentMenu("EnemyBehavior/AiMovement")]
[RequireComponent(typeof(EnController))]
[RequireComponent(typeof(Seeker))]
public class EnemyAI_Movement : MonoBehaviour
{
    Path path;
    EnController ch;
    Seeker seeker;
    Vector3 oldTargetPos = Vector3.zero;
    Transform target;

    protected PathInterpolator interpolator = new PathInterpolator();

    public bool ground = false;
    public float minDist = .5f;
    public float pathUpdateRate = .5f;

    int currentWaypoint = 0;
    bool reachedDestination = false;

    private void Awake()
    {
        ch = GetComponent<EnController>();
        seeker = GetComponent<Seeker>();
        InvokeRepeating("UpdatePath",0f,1f/pathUpdateRate);
    }

    void UpdatePath()
    {   
        //Atnaujina kelia tik tuo metu jeigu tikslas pajudejo daugiau negu leidziama, kad neapkrauti proceso, arba yra nevietoje bet per mazai juda
        if(Vector3.Distance(oldTargetPos,target.position)>=1f || (Vector2.Distance(transform.position,target.position) > minDist && ch.rg.velocity.x < .2f)) 
        {
            seeker.StartPath(transform.position, target.position, OnPathComplete);
            oldTargetPos = target.position;
        }
    }

    void OnPathComplete(Path _path) //Paskiria nauja kelia jei nera klaidu
    {
        if(!_path.error)
        {
            path = _path;
            currentWaypoint = 0;

            if (path.vectorPath.Count == 1) path.vectorPath.Add(path.vectorPath[0]);
            interpolator.SetPath(path.vectorPath);

        }
    }

    private void Update()
    {
        if (path == null)//Tikrina ar yra galiojantis kelias
        {
            return;
        }
        if(currentWaypoint >= path.vectorPath.Count) // Jeigu pasiekia savo kelio pabaiga sustabdo visa logika
        {
            reachedDestination = true;
            Debug.LogWarning("Reached Desitination change behavior depending on situation");
            return;
        }
        else
        {
            reachedDestination = false;
        }
        
        Vector2 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized; //Grazina krypti i kuria puse reikia judeti
        ch.Move(dir);
        //if(path.vectorPath[currentWaypoint].y > transform.position.y+.75f)// Patikrina ar reikia sokti kad pasiekti tiksla ar ne
        //{
        //    ch.Jump();
        //}


        if (Vector2.Distance(transform.position,path.vectorPath[currentWaypoint]) < minDist)
        {
            currentWaypoint++;
        }
    }
    public void SetTarget(Transform _target)
    {
        target = _target;
    }
}
