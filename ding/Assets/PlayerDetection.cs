using UnityEngine;
using System.Collections;

public class PlayerDetection : MonoBehaviour {
    [SerializeField]private GameObject _player;
    private bool _playerFound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector2.Distance(transform.position, _player.transform.position);
        Debug.Log(distance);

        if (distance <= 1)
        {
            //start attacking the player here
            Debug.Log("attacking Player");
        }

        if (distance <= 6)
        {
            // start following the player here
            Debug.Log("Following Player");
            _playerFound = true;
        }
        else
        {
            _playerFound = false;
            //lost sight of the player
        }
	}
