using UnityEditor;
using UnityEngine;

public static class ExtraTransformTools
{
    [MenuItem("CONTEXT/Transform/Reset Rotation")]
    static void ResetRotation(MenuCommand command)
    {
        Undo.RecordObjects(Selection.transforms, "Reset Rotation");
        foreach (var xform in Selection.transforms)
            xform.localRotation = Quaternion.identity;
    }

    [MenuItem("CONTEXT/Transform/Randomize Rotation")]
    static void RandomizeRotation(MenuCommand command)
    {
        Undo.RecordObjects(Selection.transforms, "Randomize Rotation");
        foreach (var xform in Selection.transforms)
            xform.localRotation =
              Quaternion.AngleAxis(Random.Range(-180, 180), Vector3.up);
    }
}
