using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waypointAngkot : MonoBehaviour
{

    public GameObject[] waypoint;

    int current = 0;

    float rotSpeed;
    public static float speed;
    float WPradius = 1;

    public static bool setAktive;



    void Update()
    {

        if (Vector3.Distance(waypoint[current].transform.position, transform.position) < WPradius)
        {
            current++;

            if (current >= waypoint.Length)
            {
                current = 0;
            }

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoint[current].transform.position, Time.deltaTime * speed);

    }
    
    }
