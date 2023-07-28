using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;
using Naninovel;
using TMPro;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProText; 
    private ICustomVariableManager _variableManager;
    private CustomVariableTrigger _customVariableTrigger;

    public RectTransform Marker;
    public RectTransform Location1;
    public RectTransform Location2;
    public RectTransform Location3;

    private void Start()
    {
        _variableManager = Engine.GetService<ICustomVariableManager>();
        _customVariableTrigger = GetComponent<CustomVariableTrigger>();
    }

    public void UpdateQuest()
    {
        _variableManager.TryGetVariableValue<string>(_customVariableTrigger.CustomVariableName, out var value);

        Debug.Log(_customVariableTrigger.CustomVariableName + " - " + value);

        _textMeshProText.text = value;
    }
}
