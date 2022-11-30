using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using Unity.Robotics.UrdfImporter.Control;
using JointstateMsg = RosMessageTypes.Sensor.JointStateMsg;
using RosMessageTypes.Std;

namespace Sample.UnityROSPlugins
{
    public class GameObjeTest : MonoBehaviour
    {
        public List<GameObject> jointstatePublishObject;

        void Start()
        {
            Debug.Log("object count:"+jointstatePublishObject.Count);
            for (int i=0; i<jointstatePublishObject.Count; i++){
                Debug.Log("object name:"+jointstatePublishObject[i].name);
            }
        }
    }
}