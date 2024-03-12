using UnityEditor;
using UnityEngine;

public static class ExtraTransformMenuItems
{
    [MenuItem("CONTEXT/Transform/Reset Rotation")]
    static void ResetRotation(MenuCommand command)
    {
        var xform = (Transform)command.context;
        Undo.RecordObject(xform, "Reset Rotation");
        xform.localRotation = Quaternion.identity;
    }

    [MenuItem("CONTEXT/Transform/Randomize Rotation")]
    static void RandomizeRotation(MenuCommand command)
    {
        var xform = (Transform)command.context;
        Undo.RecordObject(xform, "Randomize Rotation");
        xform.localRotation =
          Quaternion.AngleAxis(Random.Range(-180, 180), Vector3.up);
    }
}
