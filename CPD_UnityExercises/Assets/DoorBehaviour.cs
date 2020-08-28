using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public float doorCloseTime = 3f;
    private float doorCloseCounter = 3f;

    public float doorOpenTime = 3f;
    private float doorOpenCounter = 3f;

    private bool doorClosing = false;
    private bool doorOpening = false;

    void Update()
    {
        if (doorClosing)
        {
            doorCloseCounter -= Time.deltaTime;
            if (doorCloseCounter <= 0)
            {
                transform.Translate(0, -2, 0);
                doorCloseCounter = doorCloseTime;
                doorClosing = false;
            }
        }
        if (doorOpening)
        {
            doorOpenCounter -= Time.deltaTime;
            if (doorOpenCounter <= 0)
            {
                transform.Translate(0, 2, 0);
                doorOpenCounter = doorOpenTime;
                doorOpening = false;
            }
        }
    }
    public void OpenDoor()
    {
        doorOpenCounter = 3f;
        doorOpening = true;
    }
    public void CloseDoor()
    {    
        doorCloseCounter = 3f;
        doorClosing = true;
    }

}
