using UnityEngine;

namespace NetWare.UI.Styles;

public static class ButtonStyles
{
    public static GUIStyle Create()
    {
        return new GUIStyle("Box")
        {
            normal = {
                background = Texture.NewBorder(0, 0, 0, .1f, .1f, .1f),
            },

            fontStyle = FontStyle.Bold,
            fontSize = 13,
        };
    }
}
