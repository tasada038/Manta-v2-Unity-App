using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;

public class JointStateSub : MonoBehaviour
{
    public ArticulationBody[] articulationBodies;
    public string topicName = "/joint_states";
    public int jointLength = 19;
    private ROSConnection ros;

    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.Subscribe<JointStateMsg>(topicName, Callback);
    }

    void Callback(JointStateMsg msg)
    {
        for (int i = 0; i < jointLength; i++)
        {
            ArticulationDrive aDrive = articulationBodies[i].xDrive;
            aDrive.target = Mathf.Rad2Deg * (float)msg.position[i];
            articulationBodies[i].xDrive = aDrive;
        }
    }
}