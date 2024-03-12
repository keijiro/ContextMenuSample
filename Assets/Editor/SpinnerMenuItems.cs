using UnityEditor;
using UnityEngine;

public static class SpinnerMenuItems
{
    [MenuItem("CONTEXT/Spinner/Randomize Angular Velocity")]
    static void RandomizeAngularVelocity(MenuCommand command)
    {
        var spinner = (Spinner)command.context;
        Undo.RecordObject(spinner, "Randomize Angular Velocity");
        spinner.AngularVelocity = Random.Range(-180, 180);
    }
}
