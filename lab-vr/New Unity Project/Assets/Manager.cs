using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool hayBaleReturned = false;


    public GameObject finishText;

    public void checkForVictory()
    {
        if (hayBaleReturned)
        {
            finishText.SetActive(true);
        }
    }

    public void hayBaleWasReturned()
    {
        this.hayBaleReturned = true;
        checkForVictory();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
