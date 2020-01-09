using UnityEngine;
using MLAgents;
using System;
using System.Collections;
using System.Collections.Generic;

public class PinballAgent : Agent
{
    [Header("Specific to Pinball")]
    PinballAcademy m_Academy;

    public float TimeBetweenDecisionsAtInference;
    private float m_TimeSinceDecision;

    public Func<bool> GameHasEnded;
    private List<int> actionMask;

    public override void InitializeAgent()
    {
        m_Academy = FindObjectOfType(typeof(PinballAcademy)) as PinballAcademy;

        if (GameHasEnded == null)
        {
            GameHasEnded = () =>
            {
                //If ball is 0 then game is over
                return (ExtenalWindowManager.Ball == 0);
            };
        }
        actionMask = new List<int>(new[] {
            0, //Disable Idle
            //1, //Disable Z press
            //2, //Disable z relaease
            //3, //Disable / press
            //4, //Disable / relaease
            //5, //Disable Space press
            //6, //Disable Space relaease 
        });
        SetActionMask(actionMask);
    }

    public override void CollectObservations()
    {
        AddVectorObs(ExtenalWindowManager.Ball);
        AddVectorObs(ExtenalWindowManager.Score);
    }

    public override void AgentAction(float[] vectorAction)
    {
        // Perform choosen action
        var action = (int)vectorAction[0];

        // Simulate key press
        switch (action)
        {
            case 0:
                //Idle
                Debug.Log("Idle action");
                break;
            case 1:
                ExtenalWindowManager.PressKey('Z');
                actionMask.Add(1); //Disable Z press
                try { actionMask.Remove(2); } catch { } // Try remove mask for action pair
                break;
            case 2:
                ExtenalWindowManager.PressKey('Z', true);
                actionMask.Add(2); //Disable Z relaease
                try { actionMask.Remove(1); } catch { } // Try remove mask for action pair
                break;
            case 3:
                ExtenalWindowManager.PressKey('/');
                actionMask.Add(3); //Disable / press
                try { actionMask.Remove(4); } catch { } // Try remove mask for action pair
                break;
            case 4:
                ExtenalWindowManager.PressKey('/', true);
                actionMask.Add(4); //Disable / relaease
                try { actionMask.Remove(3); } catch { } // Try remove mask for action pair
                break;
            case 5:
                ExtenalWindowManager.PressKey(0x20); //space
                actionMask.Add(5); //Disable SPACE relaease
                try { actionMask.Remove(6); } catch { } // Try remove mask for action pair
                break;
            case 6:
                ExtenalWindowManager.PressKey(0x20, true); //space
                actionMask.Add(6); //Disable SPACE relaease
                try { actionMask.Remove(5); } catch { } // Try remove mask for action pair
                break;
            default:
                break;
        }
        actionMask.Sort();
        SetActionMask(actionMask);

        // Add rewards
        AddReward(0001.0f); //Stay alive benifit
        AddReward(ExtenalWindowManager.Score); // Read the scoreboard

        // End game logic
        if (GameHasEnded())
        {
            Debug.Log("Game Ended Score:" + ExtenalWindowManager.Score);
            // Press F2 to start new game
            ExtenalWindowManager.PressKey(0x71); //f2
            ExtenalWindowManager.PressKey(0x71, true); //f2

            // If high score press enter
            ExtenalWindowManager.PressKey(0x0D); //f2
            ExtenalWindowManager.PressKey(0x0D, true); //f2

            Done();
        }
    }

    public override void AgentReset()
    {
        actionMask = new List<int>(new[] {
            0, //Disable Idle
            //1, //Disable Z press
            //2, //Disable z relaease
            //3, //Disable / press
            //4, //Disable / relaease
            //5, //Disable Space press
            //6, //Disable Space relaease 
        });
    }

    public override float[] Heuristic()
    {
        return new float[] { 0 };
    }

    public override void AgentOnDone()
    {
    }

    public void FixedUpdate()
    {
        WaitTimeInference();
    }

    void WaitTimeInference()
    {
        if (!m_Academy.GetIsInference())
        {
            RequestDecision();
        }
        else
        {
            if (m_TimeSinceDecision >= TimeBetweenDecisionsAtInference)
            {
                m_TimeSinceDecision = 0f;
                RequestDecision();
            }
            else
            {
                m_TimeSinceDecision += Time.fixedDeltaTime;
            }
        }
    }
}
