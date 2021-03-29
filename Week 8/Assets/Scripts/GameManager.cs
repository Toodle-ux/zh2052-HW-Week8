using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ScenarioScriptableObject currentScenario;

    public Text scenarioNameText;
    public Text scenarioDescription;
    public Text scenarioQuestion;

    public GameObject buttonYes;
    public GameObject buttonNo;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateScenario();
    }

    public void MoveScenario(int dir)
    {
        // go to different scenarios based on players' choices
        switch (dir)
        {
            case 0:
                currentScenario = currentScenario.scenarioYes;
                break;
            case 1:
                currentScenario = currentScenario.scenarioNo;
                break;
            default:
                break;
        }
        
        UpdateScenario();
    }
    
    void UpdateScenario()
    {
        // the display of texts
        scenarioNameText.text = currentScenario.scenarioName;
        scenarioDescription.text = currentScenario.description;
        scenarioQuestion.text = currentScenario.question;

        // turn of the buttons when there is no choice
        if (currentScenario.scenarioYes == null)
        {
            buttonYes.SetActive(false);
        }
        else
        {
            buttonYes.SetActive(true);
        }
        
        if (currentScenario.scenarioNo == null)
        {
            buttonNo.SetActive(false);
        }
        else
        {
            buttonNo.SetActive(true);
        }
    }
}
