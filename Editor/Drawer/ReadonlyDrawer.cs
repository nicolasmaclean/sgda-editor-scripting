using UnityEditor;
using UnityEngine;
using SGDA.Utilities;

namespace SGDA.UtilitiesEditor.Drawer
{
    [CustomPropertyDrawer(typeof(ReadonlyAttribute))]
    public class ReadonlyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            // get the attribute instance
            ReadonlyAttribute attr = (ReadonlyAttribute) attribute;
            bool readonlyIsActive = attr.Mask.IsActive();
            
            // disable controls, if instance is currently active
            using (new EditorGUI.DisabledScope(readonlyIsActive))
            {
                // render the field to the inspector
                EditorGUI.PropertyField(position, property, label);
            }
        }
    }
}