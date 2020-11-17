using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(order = 0, fileName = "TutorialShortcutData", menuName = "Shortcut Data")]
public class TutorialShortcutData : ScriptableObject
{
    public List<ShortcutDataRecord> shortcuts;
}

[System.Serializable]
public class ShortcutDataRecord
{
    [SerializeField] private string m_Name;

    [FormerlySerializedAs("m_KeyboardRecord")] [SerializeField]
    private Binding m_Binding;

    public string name => m_Name;

    public Binding binding => m_Binding;
}

[System.Serializable]
public struct Binding
{
    [SerializeField] private KeyCode m_KeyCode;

    [SerializeField] private EventModifiers m_Modifiers;
    [SerializeField] private Color32[] m_colors;


    public Binding(KeyCode keyCode, EventModifiers modifiers, Color32[] colors) : this()
    {
        this.m_colors = colors;
        this.m_KeyCode = keyCode;
        this.m_Modifiers = modifiers;
    }

    public KeyCode keyCode => m_KeyCode;

    public EventModifiers modifiers => m_Modifiers;
    public Color32[] colors => m_colors;

    public static Binding none => new Binding();
}