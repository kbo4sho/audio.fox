 using UnityEngine;
 using System.Collections;
 
 public class HealthBar : MonoBehaviour {
     // Current progress
     public float healthDisplay; 
     private GameObject player;
     public Vector2 pos = new Vector2(20,40);
     public Vector2 size = new Vector2(60,20);
     // In case we want to use textures for empty / filled states
     public Texture2D emptyTex;
     public Texture2D fullTex;
     
     void OnGUI() {
         // Draw the background
         GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
             GUI.Box(new Rect(0,0, size.x, size.y), emptyTex);
         
             // Draw the filled-in part
             GUI.BeginGroup(new Rect(0,0, size.x * healthDisplay, size.y));
                 GUI.Box(new Rect(0,0, size.x, size.y), fullTex);
             GUI.EndGroup();
         GUI.EndGroup();
     }

     
    private void Start() {
        // This might not be necessary
        player = GameObject.Find("Player");
    }

     
     void Update() {
        // Pull in health from player manager and normalize based on 1
        healthDisplay = player.GetComponent<PlayerManager>().health * .01f;
     }
 }