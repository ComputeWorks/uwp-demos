﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UMLDiagramDesigner
{
    public class EnumTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value.ToString() == parameter.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string ret = parameter.ToString();
            switch (ret)
            {
                //Line Type
                case "Inheritance":
                    return LineType.Inheritance;
                case "AggregateOrAssociate":
                    return LineType.AggregateOrAssociate;

                //Aggregation
                case "Basic":
                    return Aggregation.Basic;
                case "Composition":
                    return Aggregation.Composition;
                case "None":
                    return Aggregation.None;

                //Association
                case "UniDirectional":
                    return Association.UniDirectional;
                case "BiDirectional":
                    return Association.BiDirectional;
            }
            return parameter;
        }
    }
}
