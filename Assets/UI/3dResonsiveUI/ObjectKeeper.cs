using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ObjectKeeper : MonoBehaviour {
    [SerializeField]
    Camera camera;
    [SerializeField]
    float X, Y;
    Vector3 pos;
    Vector3 targetPosition;
    [SerializeField]
    float smooth = 5;

    // Use this for initialization
    void Start () {
        if(camera == null)
        {
            camera = Camera.main;
        }
        
        pos = camera.WorldToViewportPoint(this.transform.position);
    }

    // Update is called once per frame

    void Update()
    {
        pos.x = X;
        pos.y = Y;
        targetPosition = camera.ViewportToWorldPoint(pos);
        ChangePosition();
    }

    public void ChangePosition()
    {
        Vector3 from = this.gameObject.transform.position;
        Vector3 to = targetPosition;

        Vector3 newPos = Vector3.Lerp(from, to, Time.deltaTime * smooth);
        this.gameObject.transform.position = newPos;
    }
}



