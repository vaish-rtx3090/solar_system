using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // declaring a variable to select the rotation target 
    public Transform target; 
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //rotate around thee first pararmeter the target position 
       //rotate around needs second parameter about the axis or rotation
       //rotate around third parameter needed is the speed of rotation.
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
