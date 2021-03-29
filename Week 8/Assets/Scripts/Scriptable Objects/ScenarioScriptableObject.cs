using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//create a menu
[CreateAssetMenu (fileName = "New Scenario",
    menuName = "ScriptableObjects/Scenario", order = 0)]

public class ScenarioScriptableObject : ScriptableObject
{
    public string scenarioName = "New Scenario";
    public string description = "Default Description";
    public string question = "Default Question";

    public ScenarioScriptableObject scenarioYes;
    public ScenarioScriptableObject scenarioNo;
}
