using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private float Distance;
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(target.position, transform.position);
        if (Distance > 10) ;
        {
            myAgent.enabled = false;
        }
        if (Distance < 10 & Distance > 1.5f) ;
        {
            myAgent.enabled = true;
        }
    }
}
