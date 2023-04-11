using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SGDA.Utilities
{
    public enum RuntimeMask
    {
        All, Edit, Play, None,
    }

    #if UNITY_EDITOR
    public static class RuntimeMaskExtensions
    {
        public static bool IsActive(this RuntimeMask mask)
        {
            bool inPlaymode = EditorApplication.isPlaying;

            switch (mask)
            {
                case RuntimeMask.All: return true;
                case RuntimeMask.Edit: return !inPlaymode;
                case RuntimeMask.Play: return inPlaymode;
                case RuntimeMask.None: return false;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
    #endif
}
