using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Moving_platfrom : MonoBehaviour
{
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        body.angularVelocity = 500;

    }
}
