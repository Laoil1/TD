using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

    public Transform self;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {


        var mousPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        var worldPos = cam.ScreenToWorldPoint(new Vector3(mousPos.x,mousPos.y,cam.nearClipPlane))*8;

        self.position = new Vector3 (worldPos.x,worldPos.y,self.position.z);
    }
}
