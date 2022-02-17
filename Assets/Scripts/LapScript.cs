using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapScript : MonoBehaviour
{
    int checkCount = 0;
    int lapCount = 1;

    GameObject viewObject;

    // Start is called before the first frame update
    void Start()
    {
        viewObject = GameObject.Find("View");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CheckPoint1")
        {
            if (checkCount == 0)
            {
                checkCount++;
            }
        }
        else if (other.gameObject.name == "CheckPoint2")
        {
            if (checkCount == 1)
            {
                checkCount++;
            }
        }
        else if (other.gameObject.name == "CheckPoint3")
        {
            if (checkCount == 2)
            {
                checkCount++;
            }
        }
        else if (other.gameObject.name == "StartGoalChecker")
        {
            if (checkCount != 3)
            {
                return;
            }
            if (lapCount != 3)
            {
                lapCount++;
                viewObject.GetComponent<ViewScript>().ShowLapCount(lapCount);
                checkCount = 0;
                return;
            }
            Debug.Log("Goal");
        }
        Debug.Log("CheckCount: " + checkCount);
        Debug.Log("LapCount: " + lapCount);
    }
}
