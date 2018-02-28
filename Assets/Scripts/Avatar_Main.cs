using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Main : MonoBehaviour
{
    //This will be the main animation manager for the synthetic characters
    [SerializeField]
    private AvatarManager manager;
    //Placeholder, system should be aware of the available tutors (by name)
    [SerializeField]
    private string tutorName = "Maria";
    Tutor tutor;

    void Start()
    {
        tutor = new Tutor(tutorName);
    }

    void Update()
    {
        if (manager == null)
            return;

        // Emotion
        if (Input.GetKey("q"))
            manager.Feel(tutor, new Emotion("Neutral", ""));
        if (Input.GetKey("w"))
            manager.Feel(tutor, new Emotion("Happy", "Low"));
        if (Input.GetKey("e"))
            manager.Feel(tutor, new Emotion("Happy", "High"));
        if (Input.GetKey("r"))
            manager.Feel(tutor, new Emotion("Sad", "Low"));
        if (Input.GetKey("t"))
            manager.Feel(tutor, new Emotion("Sad", "High"));

        // Expression
        //if (Input.GetKey("a"))
        //    ;
        //if (Input.GetKey("s"))
        //    ;
        //if (Input.GetKey("d"))
        //    ;
        //if (Input.GetKey("f"))
        //    ;
        //if (Input.GetKey("g"))
        //    ;
        //if (Input.GetKey("h"))
        //    ;
        //if (Input.GetKey("j"))
        //    ;
        //if (Input.GetKey("k"))
        //    ;
        //if (Input.GetKey("l"))
        //    ;
        //if (Input.GetKey("z"))
        //    ;
        //if (Input.GetKey("x"))
        //    ;
        //if (Input.GetKey("c"))
        //    ;
        //if (Input.GetKey("v"))
        //    ;
        //if (Input.GetKey("b"))
        //    ;
        //if (Input.GetKey("n"))
        //    ;

        // Gaze
        //if (Input.GetKey("y"))
        //    ;
        //if (Input.GetKey("u"))
        //    ;
        //if (Input.GetKey("i"))
        //    ;
        //if (Input.GetKey("o"))
        //    ;
    }
}
