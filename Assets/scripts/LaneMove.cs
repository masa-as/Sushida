using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneMove : MonoBehaviour
{
    private GameObject lane;
    private GameObject lane1;
    private GameObject lane2;
    public float lane_speed = 0.05f;
    private readonly int screen_right_x = 11;
    private readonly int screen_left_x = -11;
    // Start is called before the first frame update
    void Start()
    {
        lane = GameObject.Find("lane");
        lane1 = GameObject.Find("lane1");
        lane2 = GameObject.Find("lane2");
    }

    // Update is called once per frame
    void Update()
    {
        Transform laneTransform = lane.transform;
        Transform laneTransform1 = lane1.transform;
        Transform laneTransform2 = lane2.transform;
        Vector3 lanePos = laneTransform.position;
        Vector3 lanePos1 = laneTransform1.position;
        Vector3 lanePos2 = laneTransform2.position;
        lane.transform.Translate(lane_speed, 0, 0);
        lane1.transform.Translate(lane_speed, 0, 0);
        lane2.transform.Translate(lane_speed, 0, 0);
        if(lane.transform.position.x > screen_right_x)
        {
            lanePos.x = screen_left_x;
            laneTransform.position = lanePos;
        }
        if (lane1.transform.position.x > screen_right_x)
        {
            lanePos1.x = screen_left_x;
            laneTransform1.position = lanePos1;
        }
        if (lane2.transform.position.x > screen_right_x)
        {
            lanePos2.x = screen_left_x;
            laneTransform2.position = lanePos2;
        }
    }
}
