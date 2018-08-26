using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class NonPublic
    {
        public NonPublic()
        {
            NonPublicItem itemOne = new NonPublicItemBasic();

            NonPublicItemBasic itemOneBasic = itemOne as NonPublicItemBasic;

            itemOne.GetValue1();

            NonPublicItemBasic.GetItem()
        }
    }

    public class NonPublicItem
    {
        private int Value1;
        private int Value2;

        public int GetValue1()
        {
            return Value1;
        }

        public int GetValue2()
        {
            return Value2;
        }

        public static NonPublicItem GetItem<T>()
        {
            if (typeof(T) == typeof(NonPublicItem))
            {
                return new NonPublicItem();
            }
            else if (typeof(T) == typeof(NonPublicItemBasic))
            {
                return new NonPublicItemBasic();
            }
            else if (typeof(T) == typeof(NonPublicItemAdvanced))
            {
                return new NonPublicItemAdvanced();
            }

            return new NonPublicItem();
        }
    }

    public class NonPublicItemBasic : NonPublicItem
    {
        ValueType Value3;

        struct ValueType
        {
            int Value1;
            int Value2;
        }
    }

    public class NonPublicItemAdvanced : NonPublicItem
    {
        ValueType Value3;

        [StructLayout(LayoutKind.Explicit)]
        struct ValueType
        {
            [FieldOffset(0)]
            int Value1;
            [FieldOffset(1)]
            byte[] Value2;
        }
    }
}
