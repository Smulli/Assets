using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Poplloon.Pooler;

namespace Poplloon.Attributes
{
    public class ColorSet
    {
        //Init dictionary
        Dictionary<string, Color> _colors = new Dictionary<string, Color>();
        private int index;

        //Create a ColorSet as an object data
        public ColorSet(Dictionary<string, Color> values)
        {
            //Set the init Dictionary values as ColorSet values
            _colors = values;
        }

        public string GetNameColor() => _colors.Keys.ToArray()[index];
        //return collection value as to a list  
        public Color GetRandomColor() => _colors.Values.ToArray()[index = Random.Range(0, _colors.Count)];

        public KeyValuePair<string, Color> GetKey() => _colors.FirstOrDefault(i => i.Key == GetNameColor());
        public KeyValuePair<string, Color> GetColor() => _colors.FirstOrDefault(i => i.Value == GetRandomColor());
    }

    public class ColorData
    {
        //Set of color values in ColorSet object
        private static Dictionary<string, ColorSet> _balloonSets = new Dictionary<string, ColorSet>()
        {
            //ColorSet normal colors
            {"normal", new ColorSet(new Dictionary<string, Color>()
            {
                //key normal and his color settings
                {"RED", Color.red },
                {"BLUE", Color.blue },
                {"GREEN", Color.green },
                {"YELLOW", Color.yellow }
            }) },
            //ColorSet deuteranopia filter
            {"deuteranopia", new ColorSet(new Dictionary<string, Color>()
            {
                //key deuteranopia and his color settings
                {"RED", new Color(0.6196079f, 0.5490196f, 0, 1) },
                {"BLUE", Color.blue },
                {"GREEN", new Color(0.6980392f, 0.6313726f, 0.145098f, 1) },
                {"YELLOW", Color.yellow }
            }) }
        };

        //Get color blind filter name
        public static ColorSet GetColorSet(string _name)
        {
            //it allows to choose the desired filter in GameManager
            return _balloonSets[_name];
        }
    }
}