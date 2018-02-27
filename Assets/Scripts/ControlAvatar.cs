using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAvatar : MonoBehaviour
{
    [SerializeField]
    private AvatarController controller;

    private bool gazeBack = false;

    void Update()
    {
        if (controller == null)
            return;

        // MoodStates
        if (Input.GetKey("q"))
            controller.SetMood(MoodState.NEUTRAL);
        if (Input.GetKey("w"))
            controller.SetMood(MoodState.HAPPY_LOW);
        if (Input.GetKey("e"))
            controller.SetMood(MoodState.HAPPY_HIGH);
        if (Input.GetKey("r"))
            controller.SetMood(MoodState.SAD_LOW);
        if (Input.GetKey("t"))
            controller.SetMood(MoodState.SAD_HIGH);

        // ExpressionState
        if (Input.GetKey("a"))
            controller.ExpressEmotion(ExpressionState.NEUTRAL);
        if (Input.GetKey("s"))
            controller.ExpressEmotion(ExpressionState.HAPPY_LOW);
        if (Input.GetKey("d"))
            controller.ExpressEmotion(ExpressionState.HAPPY_HIGH);
        if (Input.GetKey("f"))
            controller.ExpressEmotion(ExpressionState.SAD_LOW);
        if (Input.GetKey("g"))
            controller.ExpressEmotion(ExpressionState.SAD_HIGH);
        if (Input.GetKey("h"))
            controller.ExpressEmotion(ExpressionState.ANGER_LOW);
        if (Input.GetKey("j"))
            controller.ExpressEmotion(ExpressionState.ANGER_HIGH);
        if (Input.GetKey("k"))
            controller.ExpressEmotion(ExpressionState.FEAR_LOW);
        if (Input.GetKey("l"))
            controller.ExpressEmotion(ExpressionState.FEAR_HIGH);
        if (Input.GetKey("z"))
            controller.ExpressEmotion(ExpressionState.DISGUST_LOW);
        if (Input.GetKey("x"))
            controller.ExpressEmotion(ExpressionState.DISGUST_HIGH);
        if (Input.GetKey("c"))
            controller.ExpressEmotion(ExpressionState.SURPRISE_LOW);
		if (Input.GetKey("v"))
            controller.ExpressEmotion(ExpressionState.SURPRISE_HIGH);
		if (Input.GetKey("b"))
			controller.ExpressEmotion(ExpressionState.HEAD_NOD);
		if (Input.GetKey("n"))
			controller.ExpressEmotion(ExpressionState.VISEMES);

        // GazeState
        if (Input.GetKey("y"))
            controller.GazeAt(GazeState.LEFT);
        if (Input.GetKey("u"))
            controller.GazeAt(GazeState.LEFT_BACK);
        if (Input.GetKey("i"))
            controller.GazeAt(GazeState.LEFT);
        if (Input.GetKey("o"))
            controller.GazeAt(GazeState.LEFT_BACK);
    }
}
