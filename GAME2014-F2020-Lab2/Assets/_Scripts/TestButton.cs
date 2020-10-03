using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public TMP_Text SceneLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event Handler for the StartButton_Pressed Event
    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        SceneLabel.text = "Test";
    }
}


