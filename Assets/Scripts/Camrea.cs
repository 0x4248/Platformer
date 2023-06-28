using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camrea : MonoBehaviour
{
    public Transform player;
    private void FixedUpdate() {
        transform.position = new Vector3(player.position.x + 8,player.position.y + 2, transform.position.z);
    }
}
