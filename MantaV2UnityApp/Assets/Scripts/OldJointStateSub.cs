
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;

public class OldJointStateSub : MonoBehaviour
{
    // Articulation Bodies
    public ArticulationBody head;
    public ArticulationBody Ltop_roll1, Ltop_pitch, Ltop_roll2;
    public ArticulationBody Lmid_roll1, Lmid_pitch, Lmid_roll2;
    public ArticulationBody Lbtm_roll1, Lbtm_pitch, Lbtm_roll2;
    public ArticulationBody Rtop_roll1, Rtop_pitch, Rtop_roll2;
    public ArticulationBody Rmid_roll1, Rmid_pitch, Rmid_roll2;
    public ArticulationBody Rbtm_roll1, Rbtm_pitch, Rbtm_roll2;
    public ArticulationBody[] joint;
    public string topicName = "/joint_states";
    public int jointLength = 19;
    private ROSConnection ros;

    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.Subscribe<JointStateMsg>(topicName, Callback);

        joint = new ArticulationBody[jointLength];
        joint[0] = head;
        joint[1] = Ltop_roll1;
        joint[2] = Ltop_pitch;
        joint[3] = Ltop_roll2;
        joint[4] = Lmid_roll1;
        joint[5] = Lmid_pitch;
        joint[6] = Lmid_roll2;
        joint[7] = Lbtm_roll1;
        joint[8] = Lbtm_pitch;
        joint[9] = Lbtm_roll2;

        joint[10] = Rtop_roll1;
        joint[11] = Rtop_pitch;
        joint[12] = Rtop_roll2;
        joint[13] = Rmid_roll1;
        joint[14] = Rmid_pitch;
        joint[15] = Rmid_roll2;
        joint[16] = Rbtm_roll1;
        joint[17] = Rbtm_pitch;
        joint[18] = Rbtm_roll2;
    }

    void Callback(JointStateMsg msg)
    {
        for (int i = 0; i < jointLength; i++)
        {
            ArticulationDrive aDrive = joint[i].xDrive;
            aDrive.target = Mathf.Rad2Deg * (float)msg.position[i];
            joint[i].xDrive = aDrive;
        }
    }
}