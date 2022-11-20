using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;




public class TransferInspectorMaterials : ScriptableWizard
{
    #region variable
    [System.Serializable]
    public class ListElement
    {
        //#region variable
        public SkinnedMeshRenderer Source;

        public SkinnedMeshRenderer Destination;
        //#endregion
    }
    public ListElement[] CopyList;
    #endregion
    [MenuItem("Tools/Open Inspector Material Transfer Window")]
    private static void Open()
    {
        DisplayWizard<TransferInspectorMaterials>("Inspector Material Transfer Window","Copy!");
    }
    private void OnWizardCreate()
    {
        transferMaterials();
    }
    void transferMaterials()
    {
        foreach (ListElement element in CopyList)
        {
            var source_materials = element.Source.sharedMaterials;
            var destination_materials = element.Destination.sharedMaterials;
            for(int i = 0; i < Mathf.Min(source_materials.Length,destination_materials.Length); i++)
            {
                destination_materials[i] = source_materials[i];
            }
            element.Destination.materials = destination_materials;

        }
        Debug.Log("Done");
        this.Close();
    }
}


