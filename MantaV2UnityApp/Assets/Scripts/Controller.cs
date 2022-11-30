
using UnityEngine;

public class Controller : MonoBehaviour
{

    // Articulation Bodies
    public ArticulationBody[] articulationBodies;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q)){
            var xDrive = this.articulationBodies[2].xDrive;
            xDrive.target -= 1f;
            this.articulationBodies[2].xDrive = xDrive;
        }
        else if (Input.GetKey(KeyCode.W)){
            var xDrive = this.articulationBodies[2].xDrive;
            xDrive.target += 1f;
            this.articulationBodies[2].xDrive = xDrive;            
        }
        else if (Input.GetKey(KeyCode.A)){
            var xDrive = this.articulationBodies[1].xDrive;
            xDrive.target -= 1f;
            this.articulationBodies[1].xDrive = xDrive;            
        }
        else if (Input.GetKey(KeyCode.S)){
            var xDrive = this.articulationBodies[1].xDrive;
            xDrive.target += 1f;
            this.articulationBodies[1].xDrive = xDrive;            
        }
        else if (Input.GetKey(KeyCode.Z)){
            var xDrive = this.articulationBodies[0].xDrive;
            xDrive.target -= 1f;
            this.articulationBodies[0].xDrive = xDrive;            
        }
        else if (Input.GetKey(KeyCode.X)){
            var xDrive = this.articulationBodies[0].xDrive;
            xDrive.target += 1f;
            this.articulationBodies[0].xDrive = xDrive;            
        }
    }
}