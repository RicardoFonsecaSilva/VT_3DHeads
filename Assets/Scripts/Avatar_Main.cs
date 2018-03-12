using System;
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
        if (Input.GetKey("a"))
            manager.Express(tutor, new Expression("Neutral", ""));
        if (Input.GetKey("s"))
            manager.Express(tutor, new Expression("Happy", "Low"));
        if (Input.GetKey("d"))
            manager.Express(tutor, new Expression("Happy", "High"));
        if (Input.GetKey("f"))
            manager.Express(tutor, new Expression("Sad", "Low"));
        if (Input.GetKey("g"))
            manager.Express(tutor, new Expression("Sad", "High"));
        if (Input.GetKey("h"))
            manager.Express(tutor, new Expression("Anger", "Low"));
        if (Input.GetKey("j"))
            manager.Express(tutor, new Expression("Anger", "High"));
        if (Input.GetKey("k"))
            manager.Express(tutor, new Expression("Fear", "Low"));
        if (Input.GetKey("l"))
            manager.Express(tutor, new Expression("Fear", "High"));
        if (Input.GetKey("z"))
            manager.Express(tutor, new Expression("Disgust", "Low"));
        if (Input.GetKey("x"))
            manager.Express(tutor, new Expression("Disgust", "High"));
        if (Input.GetKey("c"))
            manager.Express(tutor, new Expression("Surprise", "Low"));
        if (Input.GetKey("v"))
            manager.Express(tutor, new Expression("Surprise", "High"));

        // Action
        if (Input.GetKey("b"))
            manager.Act(tutor, new HeadAction("Head", "Nod"));
        if (Input.GetKey("n"))
            manager.Act(tutor, new HeadAction("Talk", ""));
        if (Input.GetKey("m"))
            manager.Act(tutor, new HeadAction("Talk", "End"));
        if (Input.GetKey("y"))
            manager.Act(tutor, new HeadAction("Gaze", "Middle to Left"));
        if (Input.GetKey("u"))
            manager.Act(tutor, new HeadAction("Gaze", "Left to Middle"));
        if (Input.GetKey("i"))
            manager.Act(tutor, new HeadAction("Gaze", "Middle to Right"));
        if (Input.GetKey("o"))
            manager.Act(tutor, new HeadAction("Gaze", "Right to Middle"));
    }
}
