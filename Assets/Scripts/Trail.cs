using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public Transform player;
    private void FixedUpdate() {
        transform.position = new Vector3(player.position.x,player.position.y, transform.position.z);
    }
}
