using UnityEngine;
using System.Collections;

public class CameraController_Test : MonoBehaviour {

    // mouse look https://www.youtube.com/watch?v=blO039OzUZc
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    GameObject player;
    //GameObject player_parent;    

    // Use this for initialization
    void Start()
    {
        // mouse look
        player = this.transform.parent.gameObject;
        // capsule player
        //player_parent = this.transform.parent.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse look
        //var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), 0);

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);

        // mouse look in the capsule
        //var md2 = new Vector2(Input.GetAxisRaw("Mouse X"), 0);

        //md2 = Vector2.Scale(md2, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        //smoothV.x = Mathf.Lerp(smoothV.x, md2.x, 1f / smoothing);
        //smoothV.y = Mathf.Lerp(smoothV.y, md2.y, 1f / smoothing);
        //mouseLook += smoothV;

        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        //player_parent.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);

    }

    //the last frame update
    void LateUpdate()
    {

    }
}
