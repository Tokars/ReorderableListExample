using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0, fileName = "LevelDataContainer", menuName = "Level Data Container")]
public class LevelDataContainer : ScriptableObject
{
    public List<LevelDataRecord> levels = new List<LevelDataRecord>();
}

[System.Serializable]
public class LevelDataRecord
{
    [Tooltip("optional")]
    [SerializeField] private string m_Name;
    [SerializeField] private BindingObject m_Binding;
    
    public string name => m_Name;
    public BindingObject binding => m_Binding;
}

[System.Serializable]
public struct BindingObject
{
    [SerializeField] [Range(1, 60)] private float levelLength;
    [SerializeField] [Range(0, 1)] private float success;
    [SerializeField] private Texture2D masterpiece;
    [SerializeField] private Color32[] m_colors;

    public BindingObject(Color32[] mColors, float levelLength, float success, Texture2D masterpiece)
    {
        m_colors = mColors;
        this.levelLength = levelLength;
        this.success = success;
        this.masterpiece = masterpiece;
    }

    public float LevelLength => levelLength;
    public float Success => success;
    public Texture2D Picture => masterpiece;
    public Color32[] colors => m_colors;

    public static BindingObject none => new BindingObject();
}