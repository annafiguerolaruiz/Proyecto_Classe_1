using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    private PlayerController player;

    [SerializeField] private Vector2 facingDirection;
   
    
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        player.transform.position = transform.position;
        player.lastDirection = facingDirection;
    }
}


