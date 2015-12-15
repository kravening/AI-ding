using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _enemyWaypoints;
    private int currentIndex;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == _enemyWaypoints[currentIndex].transform.position)
        {
            currentIndex++;
            if (currentIndex >= _enemyWaypoints.Count)
            {
                currentIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), _enemyWaypoints[currentIndex].transform.position, .1f);
    }
}