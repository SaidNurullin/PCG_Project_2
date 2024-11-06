using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    [field: SerializeField]
    public Health Health { get; private set; }

    [field: SerializeField]
    public NavMeshAgent Agent { get; private set; }

    [field: SerializeField]
    public Animator Animator { get; private set; }

    [field: SerializeField]
    public Transform Transform { get; private set; }

    [field: SerializeField]
    public Transform Target { get; private set; }

    public void SetTarget(Transform target)
    {
        Target = target;
    }
    public bool IsAlive => Health.IsAlive;
}
