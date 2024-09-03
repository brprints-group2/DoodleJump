using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    Camera cam;
    [SerializeField] private float dampValue;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, player.position.y, -10f), dampValue * Time.deltaTime);

        cam.WorldToScreenPoint(new Vector3(0, 0, 0)); //bottom left
        cam.WorldToScreenPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, 0)); //top right

        transform.position = Util.setY(transform.position, (player.position.y > transform.position.y + 3) ? player.position.y - 3: transform.position.y);
    }
}
