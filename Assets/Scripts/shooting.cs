using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public GameObject cam;
    public Camera Cam;

    private RaycastHit hit;
    private Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("camera");
        Cam = cam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("pew");
                }
            }
        
            
        }
    }
}
