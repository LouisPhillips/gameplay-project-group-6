using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public PlayerMovement player;
    public Transform respawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        player.respawnPoint = respawnPoint.position;
    }
}
