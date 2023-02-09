using EditorModal;
using UnityEditor;

public class CallEditorModalExample
{
    [MenuItem("Window/Plugins/EditorModal/Open Editor Modal Example")]
    [MenuItem("Editor Modal/Open Editor Modal Example")]
    private static void OpenEditorModal()
    {
        EditorPopupModal popupModal = (EditorPopupModal)EditorWindow.GetWindow(typeof(EditorPopupModal), true, "NOTICE", true);
        popupModal.ShowModalUtility();
        popupModal.Focus();
    }
}