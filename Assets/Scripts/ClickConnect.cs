using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickConnect : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance = 100;
            if(Physics.Raycast(ray, out hit, distance))
            {
                if (hit.rigidbody.tag == "Hookable")
                {
                    Debug.Log("Hookable clicked");
                    SpringJoint joint = GetComponent<SpringJoint>();
                    joint.connectedBody = hit.rigidbody;
                    // Connect the joint to the new hookpoint
                }
                   
                

            }
        }
    }
}
