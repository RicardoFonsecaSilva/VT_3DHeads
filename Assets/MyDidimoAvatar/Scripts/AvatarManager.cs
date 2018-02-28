using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarManager : MonoBehaviour
{
    [SerializeField]
    private List<AvatarController> Controllers;

    private Dictionary<string, MoodState> MoodDictionary;

    void Start()
    {
        MoodDictionary = new Dictionary<string, MoodState>
        {
            {"neutral", MoodState.NEUTRAL },
            {"happylow", MoodState.HAPPY_LOW },
            {"happyhigh", MoodState.HAPPY_HIGH },
            {"sadlow", MoodState.SAD_LOW },
            {"sadhigh", MoodState.SAD_HIGH }
        };
    }

    public void Feel(Tutor tutor, Emotion emotion)
    {
        AvatarController controller = getController(tutor);
        if (controller == null)
            return;

        string dKey = getDictKey(emotion);
        if (!MoodDictionary.ContainsKey(dKey))
            return;

        controller.SetMood(MoodDictionary[dKey]);
    }
    public void Express(Tutor tutor, Expression expression)
    {
        //controller.ExpressEmotion(ExpressionState.NEUTRAL);
    }

    // Handle all actions here (look, talk, nod)
    public void Act()
    {
        //controller.GazeAt(GazeState.NEUTRAL);
    }

    private AvatarController getController(Tutor tutor)
    {
        foreach (var controller in Controllers)
        {
            if (tutor.Name.Equals(controller.name))
                return controller;
        }
        return null;
    }
    private string getDictKey(Emotion emotion) {
        return string.Concat(emotion.Name,emotion.Intensity).ToLower();
    }
    private string getDictKey(Expression expression)
    {
        return string.Concat(expression.Name, expression.Intensity).ToLower();
    }
}