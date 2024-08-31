using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float dampValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, player.position.y, -10f), dampValue * Time.deltaTime);
        /*
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, player.position.x, dampValue * Time.deltaTime), 
            player.position.y, 
            -10f);
        */
    }
}
