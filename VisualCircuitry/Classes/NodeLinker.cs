using System;
using System.Drawing;
using System.Security.Cryptography;
using Circuitry.Classes;
using Circuitry.Interfaces;

namespace VisualCircuitry.Classes
{
    public class NodeLinker
    {
        private static NodeLinker Instance { get; set; }
        private NodeLinker(){}
        public Color Color { get; private set; }

        public IComponent SelectedNode { get; private set; }

        public static NodeLinker GetInstance()
        {
            return Instance ?? (Instance = new NodeLinker());
        }

        public void SetSelectedComponent(IComponent selectedComponent)
        {
            SelectedNode = selectedComponent;
        }

        //public Color GetRandomColor()
        //{
        //    var colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        //    return Color.FromKnownColor(colors[GetRandomNo(colors.Length)]);
        //}

        //private int GetRandomNo(int maxValue)
        //{
        //    var rng = RandomNumberGenerator.Create();
        //    var bytes = new byte[4];
        //    rng.GetBytes(bytes);
        //    var rndNum = BitConverter.ToInt32(bytes, 0);

        //    return Math.Abs(rndNum % maxValue);
        //}
    }
}
