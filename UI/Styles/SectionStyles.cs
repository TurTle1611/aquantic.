using UnityEngine;

namespace NetWare.UI.Styles;

public static class SectionStyles
{
    public static GUIStyle Create()
    {
        return new GUIStyle("Box")
        {
            normal = {
                background = Texture.NewBorder(.5f, .5f, .5f, .075f, .075f, .075f),
            },

            
        };
    }

    public static GUIStyle CreateTitle()
    {
        return new GUIStyle("Box")
        {
            normal = {
                background = Texture.New(.075f, .075f, .075f),
            },

            fontStyle = FontStyle.Bold,
            fontSize = 13,
        };
    }
}
