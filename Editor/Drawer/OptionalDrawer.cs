using SGDA.Utilities;
using UnityEditor;
using UnityEngine;

namespace GummiEditor.Utility
{
    [CustomPropertyDrawer(typeof(Optional<>))]
    public class OptionalDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var valueProperty = property.FindPropertyRelative("Value");
            return EditorGUI.GetPropertyHeight(valueProperty);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var valueProperty = property.FindPropertyRelative("Value");
            var enabledProperty = property.FindPropertyRelative("Enabled");

            EditorGUI.BeginProperty(position, label, property);
            
            // draw property
            position.width -= 24;
            EditorGUI.BeginDisabledGroup(!enabledProperty.boolValue);
            EditorGUI.PropertyField(position, valueProperty, label, true);
            EditorGUI.EndDisabledGroup();

            // draw toggle box
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            
            position.x += position.width + 24;
            position.width = position.height = EditorGUI.GetPropertyHeight(enabledProperty);
            position.x -= position.width;
            EditorGUI.PropertyField(position, enabledProperty, GUIContent.none);
            
            EditorGUI.indentLevel = indent;
            
            EditorGUI.EndProperty();
        }
    }
}