using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Lesson35
{
    public class NPCMove : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private NavMeshAgent _navMeshAgent;

        [Header("Patrol")]
        [SerializeField] private List<Transform> _points;

        [Header("Chase")]
        [SerializeField] private Transform _target;

        [SerializeField] private float _chaseRadius = 6f;

        private int _currentPointIndex = 0;

        [SerializeField] private bool _isChasing = false;

        private void Start()
        {
            if (_points.Count > 0)
                _navMeshAgent.SetDestination(_points[0].position);
        }

        private void Update()
        {
            if (_target == null) return;

            float distanceToTarget = Vector3.Distance(transform.position, _target.position);

            if (distanceToTarget <= _chaseRadius)
            {
                _isChasing = true;
            }
            else
            {
                _isChasing = false;
            }

            if (_isChasing)
            {
                ChaseTarget();
            }
            else
            {
                Patrol();
            }
        }

        private void ChaseTarget()
        {
            _navMeshAgent.SetDestination(_target.position);
        }

        private void Patrol()
        {
            if (_points.Count == 0) return;

            if (_navMeshAgent.remainingDistance <= _navMeshAgent.stoppingDistance)
            {
                GoToNextPoint();
            }
        }

        private void GoToNextPoint()
        {
            _currentPointIndex++;

            if (_currentPointIndex >= _points.Count)
                _currentPointIndex = 0;

            _navMeshAgent.SetDestination(_points[_currentPointIndex].position);
        }
    }
}
