using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;

public class QuestMarker : MonoBehaviour
{
    [SerializeField] private List<string> _variables;
    [SerializeField] private GameObject _target;
    private ICustomVariableManager _variableManager;
    private CustomVariableTrigger _customVariableTrigger;

    private void Start()
    {
        _variableManager = Engine.GetService<ICustomVariableManager>();
        _customVariableTrigger = GetComponent<CustomVariableTrigger>();
    }

    public void Show()
    {
        _variableManager.TryGetVariableValue<string>(_customVariableTrigger.CustomVariableName, out var value);

        foreach (string variable in _variables)
        {
            if (variable == value)
            {
                _target.SetActive(true);
                return;
            }
        }

        _target.SetActive(false);
    }
}
