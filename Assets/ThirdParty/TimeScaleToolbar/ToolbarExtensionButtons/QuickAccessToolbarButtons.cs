using System;
using UnityEditor;
using UnityEngine;
using UnityToolbarExtender;

namespace ThirdParty.TimeScaleToolbar.ToolbarExtensionButtons
{
    [InitializeOnLoad]
    public class QuickAccessToolbarButtons
    {
        static QuickAccessToolbarButtons()
        {
            ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
        }

        private static readonly GUIContent _settingsContent = new GUIContent("Settings", "Open Project Settings");
        private static readonly GUIContent _preferencesContent = new GUIContent("Prefs", "Open Preferences");
        private static readonly GUIContent _shortcutsContent = new GUIContent("KeyMap", "Open Shortcuts");
        private static readonly GUIContent _profilerContent = new GUIContent("Profiler", "Open Profiler");
        private static readonly GUIContent _frameDebuggerContent = new GUIContent("F Debug", "Open Frame Debugger");
        private static readonly GUIContent _packageManagerContent = new GUIContent("Packages", "Open Package Manager");

        private static void OnToolbarGUI()
        {
            GUILayout.Space(10);
            GUILayout.BeginHorizontal();

            if (GUILayout.Button(_settingsContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                SettingsService.OpenProjectSettings();
            }

            if (GUILayout.Button(_preferencesContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                SettingsService.OpenUserPreferences();
            }
        
            if (GUILayout.Button(_shortcutsContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                var shortcutsWindowType = Type.GetType("UnityEditor.ShortcutManagement.ShortcutManagerWindow,UnityEditor");
                if (shortcutsWindowType != null)
                {
                    EditorWindow.GetWindow(shortcutsWindowType, true, "Shortcuts");
                }
                else
                {
                    Debug.LogWarning("Could not find Shortcuts window type. Unity version may not support this.");
                }
            }

            if (GUILayout.Button(_profilerContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                EditorApplication.ExecuteMenuItem("Window/Analysis/Profiler");
            }

            if (GUILayout.Button(_frameDebuggerContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                EditorApplication.ExecuteMenuItem("Window/Analysis/Frame Debugger");
            }
        
            if (GUILayout.Button(_packageManagerContent, EditorStyles.toolbarButton, GUILayout.Width(60)))
            {
                EditorApplication.ExecuteMenuItem("Window/Package Manager");
            }

            GUILayout.EndHorizontal();
        }
    }
}