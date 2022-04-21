using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float waitTime = 3f;
    float timer;

    public TextMesh myText;

	// Use this for initialization
	void Start () {
        myText.text = "Loading...";
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
           try
            {
                myText.text = Utility.GetData();
            }
            catch (Exception ex)
            {
                myText.text = ex.Message;
            }
            finally
            {
                timer = 0f;
            }
        }
    }
}
