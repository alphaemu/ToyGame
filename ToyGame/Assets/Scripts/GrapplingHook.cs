using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{

    private LineRenderer lr;
    private Vector3 grapplingPoint;
    public LayerMask isGrappleAble;
    public Transform gunTip, camera, player;
    private SpringJoint joint; 

    private float maxDistance = 100f; 

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
 
        
        if (Input.GetMouseButtonDown(1))
        {
            StartGrapple(); 
        }
        else if (Input.GetMouseButtonDown(1))
        {
            StopGrapple(); 
        }
    }

    private void LateUpdate()
    {
        DrawRope(); 
    }
    
    
    void StartGrapple()
    {
        RaycastHit hit; 
        if (Physics.Raycast(origin: camera.position, direction: camera.forward, out hit, maxDistance))
        {
            grapplingPoint = hit.point;
            joint = player.gameObject.AddComponent<SpringJoint>();
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = grapplingPoint;

            float distanceFromPoint = Vector3.Distance(a: player.position, b: grapplingPoint);

            // The distancegrapple will try to keep fro grappling point. 
            joint.maxDistance = distanceFromPoint = 0.8f;
            joint.minDistance = distanceFromPoint * 0.25f;

            // May need to adjust these
            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 100f;

            lr.positionCount = 2; 

            player.transform.position = grapplingPoint; 

        }
    }

    void StopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }

    void DrawRope()
    {
        if (!joint) return; 
        lr.SetPosition(index: 0, gunTip.position);
        lr.SetPosition(index: 1, grapplingPoint); 
    }
    
   

}
