using System;
using UnityEngine;
using SGDA.Utilities;

[AttributeUsage(validOn: AttributeTargets.Field)]
public class ReadonlyAttribute : PropertyAttribute
{
    public RuntimeMask Mask { get; }

    public ReadonlyAttribute(RuntimeMask mask = RuntimeMask.All)
    {
        Mask = mask;
    }
}
    