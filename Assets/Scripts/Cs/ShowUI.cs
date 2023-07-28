using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class ShowUI : MonoBehaviour
{
    public GameObject target;
    private ICustomVariableManager _variableManager;
    private CustomVariableTrigger _customVariableTrigger;

    private void Start()
    {
        _variableManager = Engine.GetService<ICustomVariableManager>();
        _customVariableTrigger = GetComponent<CustomVariableTrigger>();
    }

    public void Show()
    {
        _variableManager.TryGetVariableValue<bool>(_customVariableTrigger.CustomVariableName, out var boolValue);

        Debug.Log(_customVariableTrigger.CustomVariableName + " - " + boolValue);

        target.SetActive(boolValue);
    }
}
