using UnityEngine;
using Naninovel;
using TMPro;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMeshProText; 
    private ICustomVariableManager _variableManager;
    private CustomVariableTrigger _customVariableTrigger;

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
