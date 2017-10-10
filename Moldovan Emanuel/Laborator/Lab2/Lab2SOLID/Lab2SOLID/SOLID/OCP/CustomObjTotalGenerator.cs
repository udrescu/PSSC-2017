using System.Collections.Generic;

namespace Examples.OCP
{
    public class CustomObjTotalGenerator
    {
        public int GetTotal(object[] customObjects)
        {
            var total = 0;

            foreach(object customObject in customObjects)
            {
                if(customObject is CustomType1)
                {
                    CustomType1 customType1 = (CustomType1)customObject;
                    total += customType1.Value1 + customType1.Value2 / 100;
                }

                if (customObject is CustomType1)
                {
                    CustomType2 customType1 = (CustomType2)customObject;
                    total += customType1.Value1 + customType1.Value2 / 100;
                }

                if (customObject is CustomType2)
                {
                    CustomType2 customType1 = (CustomType2)customObject;
                    total += customType1.Value1 + customType1.Value2 / 100 + 2000 + 500;
                }

                if (customObject is CustomType3)
                {
                    CustomType3 customType1 = (CustomType3)customObject;
                    total += customType1.Value1 + customType1.Value2 / 100 + 2000 + 500;
                }

                // ....... ??????
            }

            return total;
        }
    }
}
