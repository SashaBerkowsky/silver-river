using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player; // the player which will be followed by the camera
    public float offsetx; // how centered will the player be in the camera in x
    public float offsety; // how centered will the player be in the camera in y
    public float offsetSmoothing; // smoothness of the camera movement
    
    private Vector3 playerPosition; // player position in coordenates xyz
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);

        if(player.transform.localScale.x > 0f){
            playerPosition = new Vector3(playerPosition.x + offsetx, playerPosition.y + offsety, playerPosition.z);

        }
        else{
            playerPosition = new Vector3(playerPosition.x - offsetx, playerPosition.y - offsety, playerPosition.z);
        }

        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
    }
}
