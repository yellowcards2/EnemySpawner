using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoint;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (++_currentWaypoint) % _waypoints.Length;
        }

        Vector3 waypoint = _waypoints[_currentWaypoint].position;
        transform.position = Vector3.MoveTowards(transform.position, waypoint, _speed * Time.deltaTime);
    }
}
