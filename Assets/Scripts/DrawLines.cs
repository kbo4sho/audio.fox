using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{

    [SerializeField]
    // our prefab for the line, tweak the prefab in the inspector to edit this
    private GameObject LineGeneratorPrefab;
    private GameObject player;
    private LineRenderer lRend;
    
    private void Start()
    {
       SpawnLineGenerator(); 
    }

    private void SpawnLineGenerator() {
        GameObject newLineGen = Instantiate(LineGeneratorPrefab);
        lRend = newLineGen.GetComponent<LineRenderer>();
        player = GameObject.Find("Player");
    }

    private void UpdatePosition() {
        // Assign start of rope to player position
        lRend.SetPosition(0, player.transform.position);
        // Assign other end of rope to spring joint connected body position
        if (player.GetComponent<SpringJoint>().connectedBody)
        {
            lRend.SetPosition(1, player.GetComponent<SpringJoint>().connectedBody.position);
        }
    }

    private void Update() {
       UpdatePosition();
    }
}
